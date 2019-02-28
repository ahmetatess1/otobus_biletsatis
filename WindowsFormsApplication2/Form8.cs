using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Form8 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adaptor;
        OleDbCommand cmd;
        DataSet verikumesi;
        DataTable dt;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            try
            {
                label7.AutoSize = false;
                label7.Height = 2;
                label7.BorderStyle = BorderStyle.Fixed3D;

                label8.AutoSize = false;
                label8.Height = 2;
                label8.BorderStyle = BorderStyle.Fixed3D;

                label14.AutoSize = false;
                label14.Height = 403;
                label14.Width = 2;
                label14.BorderStyle = BorderStyle.Fixed3D;

                label16.AutoSize = false;
                label16.Height = 2;
                label16.BorderStyle = BorderStyle.Fixed3D;

                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Persist Security Info=True");

                //kulid çekme
                adaptor = new OleDbDataAdapter("Select * from Kullanıcı", con);
                dt = new DataTable();
                con.Open();
                adaptor.Fill(dt);
                comboBox3.DataSource = dt;
                comboBox3.ValueMember = "kulid";    // burada comboboxın value memberını yani değer parametresini veritabanındaki kaptanid alanından almasını istedim.
                comboBox3.DisplayMember = "kuladi"; // burada comboboxta gösterilcek olan veriyi veritabanındaki kaptanadi alanından almasını istedim.
                con.Close();
                //servis guzergah çekme
                adaptor = new OleDbDataAdapter("Select * from servis", con);
                dt = new DataTable();
                con.Open();
                adaptor.Fill(dt);
                comboBox4.DataSource = dt;
                comboBox4.ValueMember = "servisno";    // burada comboboxın value memberını yani değer parametresini veritabanındaki kaptanid alanından almasını istedim.
                comboBox4.DisplayMember = "servisguzergah"; // burada comboboxta gösterilcek olan veriyi veritabanındaki kaptanadi alanından almasını istedim.
                con.Close();

                //sefer tablosundaki nereden bilgileri çekiliyor
                adaptor = new OleDbDataAdapter("Select nereden from sefer", con);
                verikumesi = new DataSet();
                con.Open();
                adaptor.Fill(verikumesi, "sefer");
                foreach (DataRow Satir in verikumesi.Tables["sefer"].Rows)
                {
                    string deger = Satir[0].ToString();
                    bool durum = comboBox1.Items.Contains(deger);
                    if (!durum)
                    {
                        comboBox1.Items.Add(deger).ToString();
                    }

                }
                con.Close();
                //sefer tablosundaki nereye bilgileri çekiliyor
                adaptor = new OleDbDataAdapter("Select nereye from sefer", con);
                verikumesi = new DataSet();
                con.Open();
                adaptor.Fill(verikumesi, "sefer");
                foreach (DataRow Satir in verikumesi.Tables["sefer"].Rows)
                {
                    string deger = Satir[0].ToString();
                    bool durum = comboBox1.Items.Contains(deger);
                    if (!durum)
                    {
                        comboBox2.Items.Add(deger).ToString();
                    }

                }
                adaptor = new OleDbDataAdapter("Select * from yolcu order by yolcuno desc", con);
                dt = new DataTable();
                adaptor.Fill(dt);
                comboBox5.DataSource = dt;
                comboBox5.ValueMember = "yolcuno";
                comboBox5.DisplayMember = "yolcuadi";
                con.Close();
            }
            catch (Exception hata)
            {
                con.Close();
                MessageBox.Show(hata.ToString());                
            }
        }
        string cumle,nereden,nereye,tarih;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex!=-1)
            {
                con.Open();
                dt = new DataTable();
                nereden = comboBox1.SelectedItem.ToString();
                nereye = comboBox2.SelectedItem.ToString();
                tarih = dateTimePicker1.Text.ToString();
                cumle = "Select * from sefer where nereden like '%" + nereden + "%' and nereye like '%" + nereye + "%' and starihi like '%" + tarih + "%'";
                adaptor = new OleDbDataAdapter(cumle, con);
                adaptor.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
                MessageBox.Show("Seçmek istediğiniz seferin üzerine tıklayınız!!");
            }
            else
            {
                MessageBox.Show("Lütfen Nereden, Nereye gideceğinizi Seçiniz!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            { 
                try
                {
                    int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    for (int i = 0; i < 41; i++)
                    {
                        if (Controls[i] is CheckBox)
                        {
                            if (((CheckBox)Controls[i]).Checked && ((CheckBox)Controls[i]).Enabled !=false)
                                cmd.CommandText = @"Insert Into bilet 
                (yolcuno,seferid,kulid,servisno,koltukno,cinsiyet,ucret) 
                VALUES ('" + (comboBox5.SelectedValue).ToString() +"','" + kayit + "','" + comboBox3.SelectedValue.ToString() + "','" + comboBox4.SelectedValue.ToString() + "','" + ((CheckBox)Controls[i]).Text + "','" + "Erkek" + "','" + textBox5.Text + "')";

                        }
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bilet Alındı.", "Başarılı İşlem",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                    con.Close();
                }
            
            }

            else if (radioButton2.Checked == true)
            {
                try
                {
                    int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    for (int i = 0; i < 41; i++)
                    {
                        if (Controls[i] is CheckBox)
                        {
                            if (((CheckBox)Controls[i]).Checked && ((CheckBox)Controls[i]).Enabled != false)
                                cmd.CommandText = @"Insert Into bilet 
                (yolcuno,seferid,kulid,servisno,koltukno,cinsiyet,ucret) 
                VALUES ('" + (comboBox5.SelectedValue).ToString() + "','" + kayit + "','" + comboBox3.SelectedValue.ToString() + "','" + comboBox4.SelectedValue.ToString() + "','" + ((CheckBox)Controls[i]).Text + "','" + "Bayan" + "','" + textBox5.Text + "')";

                        }
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Bilet Alındı.", "Başarılı İşlem",
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                    con.Close();
                }

            }
            else
                MessageBox.Show("Lutfen Koltuk ve Cinsiyet Seçiniz");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < 41; i++)
            {
                if (Controls[i] is CheckBox)
                {
                    ((CheckBox)Controls[i]).Enabled = true;
                    ((CheckBox)Controls[i]).Checked = false;
                    ((CheckBox)Controls[i]).ForeColor = Color.Black;                 
                }
            }
            //checkbox çekme
            adaptor = new OleDbDataAdapter("Select koltukno,cinsiyet,seferid from bilet", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "bilet");
            MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString() + ". Seferi Seçildi.");
            foreach (DataRow Satir in verikumesi.Tables["bilet"].Rows)
            {
                int deger = Convert.ToInt16(Satir[0]);
                String renk = (Satir[1]).ToString();
                int sefer = Convert.ToInt16(Satir[2]);  
                try
                {   
                    if (sefer == Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value))
                    {
                        if (string.Compare(renk, "Erkek") == 0)
                        {
                            if (Controls[deger] is CheckBox && deger % 2==0)
                            {
                                ((CheckBox)Controls[deger]).Checked = true;
                                ((CheckBox)Controls[deger - 1]).ForeColor = Color.Blue;
                                ((CheckBox)Controls[deger]).Enabled = false;
                            }
                            if (Controls[deger] is CheckBox && deger % 2 == 1)
                            {
                                ((CheckBox)Controls[deger]).Checked = true;
                                ((CheckBox)Controls[deger+1]).ForeColor = Color.Blue;
                                ((CheckBox)Controls[deger]).Enabled = false;
                            }
                        }
                        if (string.Compare(renk, "Bayan") == 0)
                        {
                            if (Controls[deger] is CheckBox && deger % 2 == 0)
                            {
                                ((CheckBox)Controls[deger]).Checked = true;
                                ((CheckBox)Controls[deger]).Enabled = false;
                                ((CheckBox)Controls[deger-1]).ForeColor = Color.Pink;
                            }
                            if (Controls[deger] is CheckBox && deger % 2 == 1)
                            {
                                ((CheckBox)Controls[deger]).Checked = true;
                                ((CheckBox)Controls[deger]).Enabled = false;
                                ((CheckBox)Controls[deger+1]).ForeColor = Color.Pink;
                            }
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }
            }
            con.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            CheckBox check = new CheckBox();
            try
            {
                if (dataGridView1.CurrentCell==null)
                {
                    if (e.Clicks == 1)
                    {
                        MessageBox.Show("Lutfen Sefer Seçiniz");
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = textBox2.Text.ToUpper();
                textBox3.Text = textBox3.Text.ToUpper();
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = @"Insert Into yolcu 
                (yolcuadi,yolcusoyadi,yolcutc,yolcutelno) 
                VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();

                adaptor = new OleDbDataAdapter("Select * from yolcu order by yolcuno desc", con);
                dt = new DataTable();
                adaptor.Fill(dt);
                comboBox5.DataSource = dt;
                comboBox5.ValueMember = "yolcuno";
                comboBox5.DisplayMember = "yolcuadi";
                con.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
                con.Close();
            }
           
        }



    }
}
