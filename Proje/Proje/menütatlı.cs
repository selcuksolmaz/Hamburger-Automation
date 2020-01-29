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
    public partial class menütatlı : Form
    {
        public menütatlı()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        OleDbDataReader dr;
        DataSet ds;
        public void idnumber()
        {

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT MAX(ID) FROM sipariş", con);
            label12.Text = cmd.ExecuteScalar().ToString();
            con.Close();

        }
        public void toplamfiyat()
        {
            idnumber();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select toplamfiyat from sipariş where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label12.Text)));
            label20.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            idnumber();
            toplamfiyat();
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label5.Text.ToString() + "',t_fiyat ='" + Convert.ToDouble(label9.Text) + "',toplamfiyat = '" + (Convert.ToDouble(label20.Text) + Convert.ToDouble(label9.Text)) + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label12.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat ileri = new fiyat();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            idnumber();
            toplamfiyat();
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label6.Text.ToString() + "',t_fiyat ='" + Convert.ToDouble(label10.Text) + "',toplamfiyat = '" + (Convert.ToDouble(label20.Text) + Convert.ToDouble(label10.Text)) + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label12.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat ileri = new fiyat();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            idnumber();
            toplamfiyat();
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label4.Text.ToString() + "',t_fiyat ='" + Convert.ToDouble(label11.Text) + "',toplamfiyat = '" + (Convert.ToDouble(label20.Text) + Convert.ToDouble(label11.Text)) + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label12.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat ileri = new fiyat();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            idnumber();
            toplamfiyat();
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label14.Text.ToString() + "',t_fiyat ='" + Convert.ToDouble(label8.Text) + "',toplamfiyat = '" + (Convert.ToDouble(label20.Text) + Convert.ToDouble(label8.Text)) + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label12.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat ileri = new fiyat();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            idnumber();
            toplamfiyat();
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label13.Text.ToString() + "',t_fiyat ='" + Convert.ToDouble(label7.Text) + "',toplamfiyat = '" + (Convert.ToDouble(label20.Text) + Convert.ToDouble(label7.Text)) + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label12.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat ileri = new fiyat();
            this.Hide();
            ileri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idnumber();
            toplamfiyat();
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + "Hayır" + "',t_fiyat ='" + 0 + "',toplamfiyat = '" + (Convert.ToDouble(label20.Text) + 0) + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label12.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fiyat ileri = new fiyat();
            this.Hide();
            ileri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menüicecek geri = new menüicecek();
            this.Hide();
            geri.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menütatlı_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü anaekran = new anamenü();
            this.Hide();
            anaekran.Show();
        }
    }
}
