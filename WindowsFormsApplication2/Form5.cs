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
    public partial class Form5 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            con =
          new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb;Persist Security Info=True");
        }
        Form1 f1 = new Form1();
        private void Kaydet_Click(object sender, EventArgs e)
        {
            try
                {
                    cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = @"Insert Into servis 
                (Servisguzergah,servissaati,servistel) 
                VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text  + "')";
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

        
        
    }
}
