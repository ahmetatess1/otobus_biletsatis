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
    public partial class Form6 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adaptor;
        OleDbCommand cmd;
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            con =
          new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Persist Security Info=True");
            adaptor = new OleDbDataAdapter("Select * from acenta", con);
            DataTable dt = new DataTable();
            con.Open();
            adaptor.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "subeid";    // burada comboboxın value memberını yani değer parametresini veritabanındaki kaptanid alanından almasını istedim.
            comboBox1.DisplayMember = "subeadi"; // burada comboboxta gösterilcek olan veriyi veritabanındaki kaptanadi alanından almasını istedim.
            con.Close();
        }
        Form1 f1 = new Form1();
        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                try
                {
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = @"Insert Into kullanıcı
                (kulid,kuladi,kulsoyadi,gorevi,subeid) 
                VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.SelectedValue.ToString() + "')";
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
                MessageBox.Show("Lutfen Şube seçiniz");
            }
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.SelectedItem = null;
        }

        

    }
}
