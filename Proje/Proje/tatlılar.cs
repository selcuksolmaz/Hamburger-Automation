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
    public partial class tatlılar : Form
    {
        public tatlılar()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        OleDbDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            anamenü geri8 = new anamenü();
            this.Hide();
            geri8.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (tatlı,t_fiyat,toplamfiyat) values ('" + label2.Text.ToString() + "','" + Convert.ToDouble(label9.Text) + "','" + Convert.ToDouble(label9.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (tatlı,t_fiyat,toplamfiyat) values ('" + label6.Text.ToString() + "','" + Convert.ToDouble(label10.Text) + "','" + Convert.ToDouble(label10.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (tatlı,t_fiyat,toplamfiyat) values ('" + label4.Text.ToString() + "','" + Convert.ToDouble(label11.Text) + "','" + Convert.ToDouble(label11.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (tatlı,t_fiyat,toplamfiyat) values ('" + label5.Text.ToString() + "','" + Convert.ToDouble(label7.Text) + "','" + Convert.ToDouble(label7.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,tatlı,t_fiyat,toplamfiyat) values ('"+" "+"' ,'" + label8.Text.ToString() + "','" + Convert.ToDouble(label12.Text) + "','" + Convert.ToDouble(label12.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }
    }
}
