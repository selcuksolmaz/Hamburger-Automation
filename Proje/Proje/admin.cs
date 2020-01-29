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
    public partial class admin : Form
    {
        public admin()
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
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=admingirisi.mdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM admingirisi where a_ad='" + textBox1.Text + "' AND a_sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adminpaneli giris = new adminpaneli();
                giris.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yetkili adı ya da şifre yanlış");
                textBox1.Clear();
                textBox2.Clear();
            }

            con.Close();

            
        }

        private void admin_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label9.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }
    }
}
