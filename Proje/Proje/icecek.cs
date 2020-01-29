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
    public partial class icecek : Form
    {
        public icecek()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");

        DataSet ds;

        private void button1_Click(object sender, EventArgs e)
        {
            icecek2 devami = new icecek2();
            this.Hide();
            devami.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenü geri6 = new anamenü();
            this.Hide();
            geri6.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBox2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (icecek,toplamfiyat) values ('" + label6.Text.ToString() + "','" + Convert.ToDouble(label13.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (icecek,toplamfiyat) values ('" + comboBox2.SelectedItem.ToString() + "','" + Convert.ToDouble(label11.Text) +"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (icecek,toplamfiyat) values ('" + label5.Text.ToString() + "','" + Convert.ToDouble(label7.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (icecek,toplamfiyat) values ('" + label8.Text.ToString() + "','" + Convert.ToDouble(label12.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (icecek,toplamfiyat) values ('" + comboBox3.SelectedItem.ToString() + "','" + Convert.ToDouble(label17.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void icecek_Load(object sender, EventArgs e)
        {

        }
    }
}
