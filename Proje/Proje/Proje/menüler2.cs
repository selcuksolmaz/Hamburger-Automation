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
    public partial class menüler2 : Form
    {
        public menüler2()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        OleDbDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            menüler3 devami1 = new menüler3();
            devami1.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menüler geri2 = new menüler();
            this.Hide();
            geri2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü anaekran1 = new anamenü();
            this.Hide();
            anaekran1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,icecek,tatlı) values ('" + label2.Text.ToString() + "','" + " " + "','" + " " + "','" + " " + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,icecek,tatlı) values ('" + label6.Text.ToString() + "','" + " " + "','" + " " + "','" + " " + "')", con); cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,icecek,tatlı) values ('" + label4.Text.ToString() + "','" + " " + "','" + " " + "','" + " " + "')", con); cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,icecek,tatlı) values ('" + label5.Text.ToString() + "','" + " " + "','" + " " + "','" + " " + "')", con); cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,icecek,tatlı) values ('" + label8.Text.ToString() + "','" + " " + "','" + " " + "','" + " " + "')", con); cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }
    }
}
