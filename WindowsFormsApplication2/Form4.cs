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
    public partial class Form4 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adaptor;
        OleDbCommand cmd;
        DataSet verikumesi;
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            con =
          new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Persist Security Info=True");

           adaptor = new OleDbDataAdapter("Select * from kaptan", con);
            DataTable dt = new DataTable();
            con.Open();
            adaptor.Fill(dt);
            comboBox2.DataSource = dt;
            comboBox2.ValueMember = "kaptanid";    // burada comboboxın value memberını yani değer parametresini veritabanındaki kaptanid alanından almasını istedim.
            comboBox2.DisplayMember = "kaptanadi"; // burada comboboxta gösterilcek olan veriyi veritabanındaki kaptanadi alanından almasını istedim.
            con.Close();
         
        }
        Form1 f1 = new Form1();
        private void Kaydet_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex!=-1)
            {
                try
                {
                    textBox2.Text = textBox2.Text.ToUpper();
                    textBox3.Text = textBox3.Text.ToUpper();
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = @"Insert Into sefer 
                (starihi,nereden,nereye,peron,variszamani,oplaka,kaptanid) 
                VALUES ('" + dateTimePicker1.Value + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker2.Value + "','" + comboBox1.SelectedItem.ToString() + "','" + comboBox2.SelectedValue.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt Eklendi", "Başarılı İşlem",
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
            {
                MessageBox.Show("Lutfen Kaptan ve Otobus bilgilerini seçiniz");
            }


        }



        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            adaptor = new OleDbDataAdapter("Select oplaka from otobus", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "otobus");
            foreach (DataRow Satir in verikumesi.Tables["otobus"].Rows)
            {
                string deger = Satir[0].ToString();
                bool durum = comboBox1.Items.Contains(deger);
                if (!durum)
                {
                    comboBox1.Items.Add(deger).ToString();
                }

                con.Close();
            }
        
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            dateTimePicker2.Value = DateTime.Today;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
        }

    }
}
