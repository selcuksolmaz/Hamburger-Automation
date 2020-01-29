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
    public partial class menüler : Form
    {
        public menüler()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        
        DataSet ds;
       

        private void button1_Click(object sender, EventArgs e)
        {
            menüler2 devami = new menüler2();
            devami.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            anamenü geri3 = new anamenü();
            this.Hide();
            geri3.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü anaekran = new anamenü();
            this.Hide();
            anaekran.Show();
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
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,icecek,tatlı) values ('" + label6.Text.ToString() + "','" + " " + "','" + " " + "','" + " " + "')", con);
            cmd.ExecuteNonQuery();
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
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,büyükküçük,icecek,tatlı) values ('" + label5.Text.ToString() + "','" + " " + "','" + " " + "','" + " " + "')", con);
            cmd.ExecuteNonQuery();
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

        private void menüler_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
