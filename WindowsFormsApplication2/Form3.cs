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
    public partial class Form3 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con =
          new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Persist Security Info=True");
        }
        int durum = 0,durum2;
        Form1 f1 = new Form1();
        private void Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                
            if (checkBox2.Checked)
                durum= 1;
            else
                durum = 0;
            if (checkBox1.Checked)
                durum2 = 1;
            else
                durum2 = 0;

                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = @"Insert Into otobus 
                (oplaka,modeli,koltuksayısı,tv,wifi) 
                VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + durum + "','" + durum2 + "')";
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

        private void Temizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }


    }
}
