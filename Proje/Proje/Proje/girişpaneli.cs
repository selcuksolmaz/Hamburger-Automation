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
    
namespace Proje
{
    public partial class girişpaneli : Form
    {
        public girişpaneli()
        {
            InitializeComponent();
        }

        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;


        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox1.Text;
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kullanici.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici where k_ad='" + textBox1.Text + "' AND k_sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                anamenü f1= new anamenü();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                textBox1.Clear();
                textBox2.Clear();
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }

        private void girişpaneli_Load(object sender, EventArgs e)
        {

        }

        private void girişpaneli_Load_1(object sender, EventArgs e)
        {

        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            
            Application.Exit();
        }
    }
}
