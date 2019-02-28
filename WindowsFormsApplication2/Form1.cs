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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //veri tabanı bağlantısı yapıldı
        OleDbConnection con;
        OleDbDataAdapter adaptor;
        OleDbCommand cmd;
        DataSet verikumesi;
        OleDbCommandBuilder cmdb;
        DataTable tbl;
        int kayittut = -1;
        void vtbaglantı()
        {
            con =
            new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Persist Security Info=True");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            vtbaglantı();
        }

        private void kaptanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 yeni=new Form2();
            yeni.MdiParent=this;
            yeni.Show();
        }

        private void otobüsEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.MdiParent = this;
            yeni.Show();
        }

        private void seferEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 yeni = new Form4();
            yeni.MdiParent = this;
            yeni.Show();
        }

        private void servisEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.MdiParent = this;
            yeni.Show();
        }

        private void acentaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 yeni = new Form7();
            yeni.MdiParent = this;
            yeni.Show();

        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form6 yeni = new Form6();
            yeni.MdiParent = this;
            yeni.Show();

        }

        private void tabloKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Location = new Point(2,575);
            dataGridView1.Size = new Size(this.Size.Width - 20, 0);


        }

        public void kaptanListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vtbaglantı();
            dataGridView1.Location = new Point(2, this.Size.Height-291);
            dataGridView1.Size = new Size(this.Size.Width-20, 250);
            adaptor = new OleDbDataAdapter("Select * from kaptan", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "kaptan");
            dataGridView1.DataSource = verikumesi.Tables["kaptan"];
            con.Close();
            kayittut = 0;

        }

        public void otobüsListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vtbaglantı();
            dataGridView1.Location = new Point(2, this.Size.Height-291);
            dataGridView1.Size = new Size(this.Size.Width-20, 250);
            adaptor = new OleDbDataAdapter("Select * from otobus", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "otobus");
            dataGridView1.DataSource = verikumesi.Tables["otobus"];
            con.Close();
            kayittut = 1;
        }

        public void seferListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vtbaglantı();
            dataGridView1.Location = new Point(2, this.Size.Height-291);
            dataGridView1.Size = new Size(this.Size.Width-20, 250);
            adaptor = new OleDbDataAdapter("Select * from sefer", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "sefer");
            dataGridView1.DataSource = verikumesi.Tables["sefer"];
            con.Close();
            kayittut = 2;
        }

        public void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vtbaglantı();
            dataGridView1.Location = new Point(2, this.Size.Height-291);
            dataGridView1.Size = new Size(this.Size.Width-20, 250);
            adaptor = new OleDbDataAdapter("Select * from kullanıcı", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "kullanıcı");
            dataGridView1.DataSource = verikumesi.Tables["kullanıcı"];
            con.Close();
            kayittut = 3;
        }

        public void acentaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vtbaglantı();
            dataGridView1.Location = new Point(2, this.Size.Height-291);
            dataGridView1.Size = new Size(this.Size.Width-20, 250);
            adaptor = new OleDbDataAdapter("Select * from acenta", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "acenta");
            dataGridView1.DataSource = verikumesi.Tables["acenta"];
            con.Close();
            kayittut = 4;
        }

        public void servisListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vtbaglantı();
            dataGridView1.Location = new Point(2, this.Size.Height-291);
            dataGridView1.Size = new Size(this.Size.Width-20, 250);
            adaptor = new OleDbDataAdapter("Select * from servis", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "servis");
            dataGridView1.DataSource = verikumesi.Tables["servis"];
            con.Close();
            kayittut = 5;
        }

        public void yolcuListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vtbaglantı();
            dataGridView1.Location = new Point(2, this.Size.Height-291);
            dataGridView1.Size = new Size(this.Size.Width-20, 250);
            adaptor = new OleDbDataAdapter("Select * from yolcu", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "yolcu");
            dataGridView1.DataSource = verikumesi.Tables["yolcu"];
            con.Close();
            kayittut = 6;
        }

        public void satılanBiletListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vtbaglantı();
            dataGridView1.Location = new Point(2, this.Size.Height-291);
            dataGridView1.Size = new Size(this.Size.Width-20, 250);
            adaptor = new OleDbDataAdapter("Select b.yolcuno,y.yolcutc,y.yolcuadi,y.yolcusoyadi,b.seferid,s.nereden,s.nereye,s.peron,b.kulid,k.kuladi as İslYapKulAdı,b.servisno ,sv.servisguzergah,b.koltukno,cinsiyet,ucret from "
            + "bilet as b inner join sefer as s on b.seferid=s.seferid,yolcu y,kullanıcı k,servis sv where b.yolcuno=y.yolcuno and "
            +"k.kulid=b.kulid and sv.servisno=b.servisno ", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "bilet");
            dataGridView1.DataSource = verikumesi.Tables["bilet"];
            con.Close();
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            kayittut = 7;
        }
        //dbdeki index degerlerinin değişmesini engellemekiçin
        private void düzenleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (kayittut != 7)
            {
                if (dataGridView1.ReadOnly == true)
                {
                    dataGridView1.ReadOnly = false;
                    dataGridView1.Columns[0].ReadOnly = true;
                    MessageBox.Show("Bu alanda Güncelleme yaparken düzenleme yaptıktan sonra enter'a tıklayınız!!");
                }
                else
                    dataGridView1.ReadOnly = true;
            }
            else if (kayittut == 7)
            {
                if (dataGridView1.ReadOnly == true)
                {
                    dataGridView1.ReadOnly = false;
                    dataGridView1.Columns[0].ReadOnly = true;
                    dataGridView1.Columns[4].ReadOnly = true;
                    dataGridView1.Columns[8].ReadOnly = true;
                    dataGridView1.Columns[10].ReadOnly = true;
                    MessageBox.Show("Bu alanda Güncelleme yaparken düzenleme yaptıgınız alan ile kaydete tıkladığınız alanların aynı satırda olmasına dikkat ediniz!!");
                }
                else
                    dataGridView1.ReadOnly = true;
            }

        }
        //datagrid üzerinde düzenledikten sonra kaydetmek için
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (kayittut == 0)
                {
                    cmdb = new OleDbCommandBuilder(adaptor);
                    adaptor.Update(verikumesi, "kaptan");
                    kaptanListeleToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Kayıt güncellendi");
                }
                else if (kayittut == 1)
                {
                    cmdb = new OleDbCommandBuilder(adaptor);
                    adaptor.Update(verikumesi, "otobus");
                    otobüsListeleToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Kayıt güncellendi");

                }
                else if (kayittut == 2)
                {
                    cmdb = new OleDbCommandBuilder(adaptor);
                    adaptor.Update(verikumesi, "sefer");
                    seferListeleToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Kayıt güncellendi");
                }
                else if (kayittut == 3)
                {
                    cmdb = new OleDbCommandBuilder(adaptor);
                    adaptor.Update(verikumesi, "kullanıcı");
                    kullanıcıListeleToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Kayıt güncellendi");

                }
                else if (kayittut == 4)
                {
                    cmdb = new OleDbCommandBuilder(adaptor);
                    adaptor.Update(verikumesi, "acenta");
                    acentaListeleToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Kayıt güncellendi");
                }
                else if (kayittut == 5)
                {
                    cmdb = new OleDbCommandBuilder(adaptor);
                    adaptor.Update(verikumesi, "servis");
                    servisListeleToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Kayıt güncellendi");

                }
                else if (kayittut == 6)
                {
                    cmdb = new OleDbCommandBuilder(adaptor);
                    adaptor.Update(verikumesi, "yolcu");
                    yolcuListeleToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Kayıt güncellendi");
                }
                else if (kayittut == 7)
                {
                    int yolcuid = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    string yolcutc = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string yolcuad = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string yolcusoy = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string peron = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    string nereden = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    string nereye = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    string kuladi = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    string gzgah = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                    string kno = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                    string cins = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                    string ucret = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                    int servisno = Int32.Parse(dataGridView1.CurrentRow.Cells[10].Value.ToString());
                    int kulid = Int32.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                    int seferid = Int32.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "update yolcu set yolcuadi='" + yolcuad + "', yolcusoyadi='" + yolcusoy + "', yolcutc='" + yolcutc + "' where yolcuno=" + yolcuid + " ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update sefer set nereden='" + nereden + "', nereye='" + nereye + "', peron='" + peron + "' where seferid=" + seferid + " ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update kullanıcı set kuladi='" + kuladi + "' where kulid=" + kulid + " ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update servis set servisguzergah='" + gzgah + "' where servisno=" + servisno + " ";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "update bilet set koltukno='" + kno + "', cinsiyet='" + cins + "', ucret='" + ucret + "' where yolcuno=" + yolcuid + " and seferid="+ seferid + " ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    satılanBiletListeleToolStripMenuItem_Click(sender, e);
                    MessageBox.Show("Kayıt güncellendi");
                    
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
                con.Close();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (dataGridView1.Size.Height != 0)
            {
                dataGridView1.Location = new Point(2, this.Size.Height - 291);
                dataGridView1.Size = new Size(this.Size.Width - 20, 250);
            } 
            if (panel1.Size.Height != 0)
            {
                panel1.Location = new Point(this.Size.Width - 214, this.Size.Height - 236);
                panel1.Size = new Size(196, 195);
            }
        }

        //hücre içinde düzenleme yapılıp yapılmadıgının kontrolu
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.IsInEditMode == true)
                {
                    MessageBox.Show("Lutfen Düzenlemeyi Bitirip Tekrar Deneyiniz!!");
                    contextMenuStrip1.Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Enabled = true;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Hücre Seçilmedi");
            }
        }
        //dbden veri silme
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı Silmek İstediğinizden Eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (kayittut == 0)
                {
                    try
                    {
                        int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = ("Delete From kaptan where kaptanid=" + kayit + " ");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        kaptanListeleToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Kayıt Silindi");
                    }
                    catch (Exception hata)
                    {
                        con.Close();
                        MessageBox.Show(hata.Message);
                    }
                }
                if (kayittut == 1)
                {
                    try
                    {
                        String kayit = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        MessageBox.Show(kayit.ToString());
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = ("Delete From otobus where oplaka ='" + kayit + "'");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        otobüsListeleToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Kayıt Silindi");
                    }
                    catch (Exception hata)
                    {
                        con.Close();
                        MessageBox.Show(hata.Message);
                    }

                }
                if (kayittut == 2)
                {
                    try
                    {
                        int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = ("Delete From sefer where seferid=" + kayit + " ");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        seferListeleToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Kayıt Silindi");
                    }
                    catch (Exception hata)
                    {
                        con.Close();
                        MessageBox.Show(hata.Message);
                    }
                }
                if (kayittut == 3)
                {
                    try
                    {
                        int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = ("Delete From kullanıcı where kulid=" + kayit + " ");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        kullanıcıListeleToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Kayıt Silindi");
                    }
                    catch (Exception hata)
                    {
                        con.Close();
                        MessageBox.Show(hata.Message);
                    }
                }
                if (kayittut == 4)
                {
                    try
                    {
                        int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = ("Delete From acenta where subeid=" + kayit + " ");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        acentaListeleToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Kayıt Silindi");
                    }
                    catch (Exception hata)
                    {
                        con.Close();
                        MessageBox.Show(hata.Message);
                    }
                }
                if (kayittut == 5)
                {
                    try
                    {
                        int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = ("Delete From servis where servisno=" + kayit + " ");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        servisListeleToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Kayıt Silindi");
                    }
                    catch (Exception hata)
                    {
                        con.Close();
                        MessageBox.Show(hata.Message);
                    }
                }
                if (kayittut == 6)
                {
                    try
                    {
                        int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = ("Delete From yolcu where yolcuno=" + kayit + " ");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        yolcuListeleToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Kayıt Silindi");
                    }
                    catch (Exception hata)
                    {
                        con.Close();
                        MessageBox.Show(hata.Message);
                    }
                }
                if (kayittut == 7)
                {
                    try
                    {
                        int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        int skayit = Int32.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        cmd = new OleDbCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandText = ("Delete From bilet where yolcuno=" + kayit + " and seferid="+ skayit + " ");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        satılanBiletListeleToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Kayıt Silindi");
                    }
                    catch (Exception hata)
                    {
                        con.Close();
                        MessageBox.Show(hata.Message);
                    }
                }


            }
        }
        string neye, cumle;
        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seçili Hücrenin Sütun Adına Göre Arama Yapılacaktır.");
            panel1.Location=new Point(this.Size.Width-284,this.Size.Height-236);
            panel1.Size=new Size(266,215);
        }

        //panelin içindeki ara butonu, dbden yazılan metne göre bilgileri cekiyor ve datagridi güncelliyor.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (kayittut == 0)
                {
                    con.Open();
                    tbl = new DataTable();
                    if (dataGridView1.CurrentCell != null)
                        neye = dataGridView1.CurrentCell.OwningColumn.HeaderText;
                    else
                        neye = "kaptanadi";
                    cumle = "Select * from kaptan where " + neye + " like '%" + textBox1.Text + "%'";
                    adaptor = new OleDbDataAdapter(cumle, con);
                    adaptor.Fill(tbl);
                    con.Close();
                    dataGridView1.DataSource = tbl;
                }
                if (kayittut == 1)
                {
                    con.Open();
                    tbl = new DataTable();
                    if (dataGridView1.CurrentCell != null)
                        neye = dataGridView1.CurrentCell.OwningColumn.HeaderText;
                    else
                        neye = "oplaka";
                    cumle = "Select * from otobus where " + neye + " like '%" + textBox1.Text + "%'";
                    adaptor = new OleDbDataAdapter(cumle, con);
                    adaptor.Fill(tbl);
                    con.Close();
                    dataGridView1.DataSource = tbl;
                }
                if (kayittut == 2)
                {
                    con.Open();
                    tbl = new DataTable();
                    if (dataGridView1.CurrentCell != null)
                        neye = dataGridView1.CurrentCell.OwningColumn.HeaderText;
                    else
                        neye = "nereden";
                    cumle = "Select * from sefer where " + neye + " like '%" + textBox1.Text + "%'";
                    adaptor = new OleDbDataAdapter(cumle, con);
                    adaptor.Fill(tbl);
                    con.Close();
                    dataGridView1.DataSource = tbl;
                }
                if (kayittut == 3)
                {
                    con.Open();
                    tbl = new DataTable();
                    if (dataGridView1.CurrentCell != null)
                        neye = dataGridView1.CurrentCell.OwningColumn.HeaderText;
                    else
                        neye = "kuladi";
                    cumle = "Select * from kullanıcı where " + neye + " like '%" + textBox1.Text + "%'";
                    adaptor = new OleDbDataAdapter(cumle, con);
                    adaptor.Fill(tbl);
                    con.Close();
                    dataGridView1.DataSource = tbl;
                }
                if (kayittut == 4)
                {
                    con.Open();
                    tbl = new DataTable();
                    if (dataGridView1.CurrentCell != null)
                        neye = dataGridView1.CurrentCell.OwningColumn.HeaderText;
                    else
                        neye = "subeadi";
                    cumle = "Select * from acenta where " + neye + " like '%" + textBox1.Text + "%'";
                    adaptor = new OleDbDataAdapter(cumle, con);
                    adaptor.Fill(tbl);
                    con.Close();
                    dataGridView1.DataSource = tbl;
                }
                if (kayittut == 5)
                {
                    con.Open();
                    tbl = new DataTable();
                    if (dataGridView1.CurrentCell != null)
                        neye = dataGridView1.CurrentCell.OwningColumn.HeaderText;
                    else
                        neye = "servisguzergah";
                    cumle = "Select * from servis where " + neye + " like '%" + textBox1.Text + "%'";
                    adaptor = new OleDbDataAdapter(cumle, con);
                    adaptor.Fill(tbl);
                    con.Close();
                    dataGridView1.DataSource = tbl;
                }
                if (kayittut == 6)
                {
                    con.Open();
                    tbl = new DataTable();
                    if (dataGridView1.CurrentCell != null)
                        neye = dataGridView1.CurrentCell.OwningColumn.HeaderText;
                    else
                        neye = "yolcuadi";
                    cumle = "Select * from yolcu where " + neye + " like '%" + textBox1.Text + "%'";
                    adaptor = new OleDbDataAdapter(cumle, con);
                    adaptor.Fill(tbl);
                    con.Close();
                    dataGridView1.DataSource = tbl;
                }
                if (kayittut == 7)
                {
                    con.Open();
                    tbl = new DataTable();
                    if (dataGridView1.CurrentCell != null)
                    {
                        neye = dataGridView1.CurrentCell.OwningColumn.HeaderText;
                        if (dataGridView1.CurrentCell.OwningColumn.HeaderText == "yolcuno")
                            neye = "b." + dataGridView1.CurrentCell.OwningColumn.HeaderText;
                        if (dataGridView1.CurrentCell.OwningColumn.HeaderText == "İslYapKulAdı")
                            neye = "k.kuladi";
                        if (dataGridView1.CurrentCell.OwningColumn.HeaderText == "seferid")
                            neye = "b." + dataGridView1.CurrentCell.OwningColumn.HeaderText;
                        if (dataGridView1.CurrentCell.OwningColumn.HeaderText == "servisno")
                            neye = "b." + dataGridView1.CurrentCell.OwningColumn.HeaderText;
                        if (dataGridView1.CurrentCell.OwningColumn.HeaderText == "kulid")
                            neye = "b." + dataGridView1.CurrentCell.OwningColumn.HeaderText;
                    }
                    else
                        neye = "koltukno";
                    cumle = "Select b.yolcuno,y.yolcutc,y.yolcuadi,y.yolcusoyadi,b.seferid,s.nereden,s.nereye,s.peron,b.kulid,k.kuladi as İslYapKulAdı,b.servisno ,sv.servisguzergah,b.koltukno,cinsiyet,ucret from "
                + "bilet as b inner join sefer as s on b.seferid=s.seferid,yolcu y,kullanıcı k,servis sv where b.yolcuno=y.yolcuno and "
                + "k.kulid=b.kulid and sv.servisno=b.servisno and " + neye + " like '%" + textBox1.Text + "%'";
                    adaptor = new OleDbDataAdapter(cumle, con);
                    adaptor.Fill(tbl);
                    con.Close();
                    dataGridView1.DataSource = tbl;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
                con.Close();
            }

        }
        //panel kapatma
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(0, 0);
        }

        private void biletSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.MdiParent = this;
            f8.Show();
        }

        private void biletİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.MdiParent = this;
            f9.Show();
        }
      

      
    }
}

