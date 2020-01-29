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
    public partial class menüicecek : Form
    {
        public menüicecek()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        OleDbDataReader dr;
        public void idnumber()
        {

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT MAX(ID) FROM sipariş", con);
            label7.Text = cmd.ExecuteScalar().ToString();
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menüboyut geri = new menüboyut();
            this.Hide();
            geri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menüicecek2 ileri = new menüicecek2();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBox2.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("update sipariş set icecek= '" + comboBox2.Text.ToString() + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label7.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            menütatlı ileri = new menütatlı();
            this.Hide();
            ileri.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("update sipariş set icecek= '" + comboBox1.Text.ToString() + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label7.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            menütatlı ileri = new menütatlı();
            this.Hide();
            ileri.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("update sipariş set icecek= '" + comboBox3.Text.ToString() + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label7.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            menütatlı ileri = new menütatlı();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("update sipariş set icecek= '" + label5.Text.ToString() + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label7.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            menütatlı ileri = new menütatlı();
            this.Hide();
            ileri.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("update sipariş set icecek= '" + label8.Text.ToString() + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label7.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            menütatlı ileri = new menütatlı();
            this.Hide();
            ileri.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
