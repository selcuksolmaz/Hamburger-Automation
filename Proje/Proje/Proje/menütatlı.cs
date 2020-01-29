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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label5.Text.ToString() + "' where ID=@id", con);
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
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label6.Text.ToString() + "' where ID=@id", con);
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
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label4.Text.ToString() + "' where ID=@id", con);
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
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label14.Text.ToString() + "' where ID=@id", con);
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
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + label13.Text.ToString() + "' where ID=@id", con);
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
            OleDbCommand cmd = new OleDbCommand("update sipariş set tatlı= '" + "Hayır" + "' where ID=@id", con);
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
    }
}
