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
    public partial class Form9 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adaptor;
        OleDbCommand cmd;
        DataSet verikumesi;
        DataTable dt;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Persist Security Info=True");
            adaptor = new OleDbDataAdapter("Select b.yolcuno,y.yolcutc,y.yolcuadi,y.yolcusoyadi,b.seferid,s.nereden,s.nereye,s.peron,sv.servisguzergah,b.koltukno,cinsiyet,ucret from "
            + "bilet as b inner join sefer as s on b.seferid=s.seferid,yolcu y,kullanıcı k,servis sv where b.yolcuno=y.yolcuno and "
            + "k.kulid=b.kulid and sv.servisno=b.servisno ", con);
            verikumesi = new DataSet();
            con.Open();
            adaptor.Fill(verikumesi, "bilet");
            dataGridView1.DataSource = verikumesi.Tables["bilet"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[0].Selected)
                {
                    int kayit = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = ("Delete From bilet where yolcuno=" + kayit + " ");
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayıt Silindi", "Başarılı İşlem..");
                    this.Close();
                }
                else
                    MessageBox.Show("Lutfen Silmek İstediğiniz Bileti Seçiniz.","Uyarı!!");
            }
            catch (Exception hata)
            {
                con.Close();
                MessageBox.Show(hata.Message);
            }
        }
        string cumle;
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            dt = new DataTable();
            cumle = "Select b.yolcuno,y.yolcutc,y.yolcuadi,y.yolcusoyadi,b.seferid,s.nereden,s.nereye,s.peron,sv.servisguzergah,b.koltukno,cinsiyet,ucret from "
            + "bilet as b inner join sefer as s on b.seferid=s.seferid,yolcu y,kullanıcı k,servis sv where b.yolcuno=y.yolcuno and "
            + "k.kulid=b.kulid and sv.servisno=b.servisno "
            + "and y.yolcuadi like '%" + textBox1.Text + "%' and y.yolcusoyadi like '%" + textBox2.Text + "%' and y.yolcutc like'%" + textBox3.Text + "%'";
            adaptor = new OleDbDataAdapter(cumle, con);
            adaptor.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
        }

    }
}
