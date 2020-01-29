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
    public partial class yanürün : Form
    {
        public yanürün()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        OleDbDataReader dr;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,bk_fiyat,toplamfiyat) values ('" + " " + "' ,'" + label2.Text.ToString() + "','" + Convert.ToDouble(label9.Text) + "','" + Convert.ToDouble(label9.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenü geri6 = new anamenü();
            this.Hide();
            geri6.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,bk_fiyat,toplamfiyat) values ('" + " " + "' ,'" + label6.Text.ToString() + "','" + Convert.ToDouble(label10.Text) + "','" + Convert.ToDouble(label10.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,bk_fiyat,toplamfiyat) values ('" + " " + "' ,'" + label4.Text.ToString() + "','" + Convert.ToDouble(label12.Text) + "','" + Convert.ToDouble(label12.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,bk_fiyat,toplamfiyat) values ('" + " " + "' ,'" + label5.Text.ToString() + "','" + Convert.ToDouble(label15.Text) + "','" + Convert.ToDouble(label15.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,bk_fiyat,toplamfiyat) values ('" + " " + "' ,'" + label8.Text.ToString() + "','" + Convert.ToDouble(label17.Text) + "','" + Convert.ToDouble(label17.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat f1 = new fiyat();
            f1.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü geri7 = new anamenü();
            this.Hide();
            geri7.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
