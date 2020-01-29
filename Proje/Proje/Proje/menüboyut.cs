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
    public partial class menüboyut : Form
    {
        public menüboyut()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        OleDbDataReader dr;

        public void idnumber()
        {

            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT MAX(ID) FROM sipariş", con);
            label5.Text = cmd.ExecuteScalar().ToString();
            con.Close();

        }
        
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("update sipariş set büyükküçük= '" + "Evet" + "' where ID=@id", con);
            cmd.Parameters.AddWithValue("@id",(Convert.ToInt32(label5.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            menüicecek ileri = new menüicecek();
            this.Hide();
            ileri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("update sipariş set büyükküçük= '" + "Hayır" + "'where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label5.Text)));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            menüicecek ileri = new menüicecek();
            this.Hide();
            ileri.Show();
        }
    }
}
