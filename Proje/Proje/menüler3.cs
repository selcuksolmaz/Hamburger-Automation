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
    public partial class menüler3 : Form
    {
        public menüler3()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        OleDbDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            menüler2 geri = new menüler2();
            this.Hide();
            geri.Show();
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü anaekran2 = new anamenü();
            this.Hide();
            anaekran2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,m_fiyat,büyükküçük,bk_fiyat,icecek,tatlı,t_fiyat,toplamfiyat) values ('" + label8.Text.ToString() + "','" + Convert.ToDouble(label12.Text) + "','" + " " + "','" + 0 + "','" + " " + "','" + " " + "','" + 0 + "','" + Convert.ToDouble(label12.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,m_fiyat,büyükküçük,bk_fiyat,icecek,tatlı,t_fiyat,toplamfiyat) values ('" + label5.Text.ToString() + "','" + Convert.ToDouble(label7.Text) + "','" + " " + "','" + 0 + "','" + " " + "','" + " " + "','" + 0 + "','" + Convert.ToDouble(label7.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,m_fiyat,büyükküçük,bk_fiyat,icecek,tatlı,t_fiyat,toplamfiyat) values ('" + label4.Text.ToString() + "','" + Convert.ToDouble(label11.Text) + "','" + " " + "','" + 0 + "','" + " " + "','" + " " + "','" + 0 + "','" + Convert.ToDouble(label11.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,m_fiyat,büyükküçük,bk_fiyat,icecek,tatlı,t_fiyat,toplamfiyat) values ('" + label6.Text.ToString() + "','" + Convert.ToDouble(label10.Text) + "','" + " " + "','" + 0 + "','" + " " + "','" + " " + "','" + 0 + "','" + Convert.ToDouble(label10.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into sipariş (Menü,m_fiyat,büyükküçük,bk_fiyat,icecek,tatlı,t_fiyat,toplamfiyat) values ('" + label2.Text.ToString() + "','" + Convert.ToDouble(label9.Text) + "','" + " " + "','" + 0 + "','" + " " + "','" + " " + "','" + 0 + "','" + Convert.ToDouble(label9.Text) + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            menüboyut ileri = new menüboyut();
            this.Hide();
            ileri.Show();
        }

        private void menüler3_Load(object sender, EventArgs e)
        {

        }
    }
}
