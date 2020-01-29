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
    public partial class psil : Form
    {
        public psil()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kullanici.mdb");
        OleDbCommand cmd;
        OleDbDataReader dr;

        private void verileriGoster()
        {
            listView1.Items.Clear();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From kullanici";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["ID"].ToString();
                ekle.SubItems.Add(dr["k_ad"].ToString());
                ekle.SubItems.Add(dr["k_sifre"].ToString());
                ekle.SubItems.Add(dr["Ad"].ToString());
                ekle.SubItems.Add(dr["Soyad"].ToString());
                ekle.SubItems.Add(dr["Yas"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Eposta"].ToString());
                listView1.Items.Add(ekle);
               


            }
            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            verileriGoster();
        }

        private void psil_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "SELECT * FROM kullanici where Eposta='" + textBox1.Text + "'";
            dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                cmd.Connection = con;
                cmd.CommandText = "delete from kullanici where Eposta= '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                verileriGoster();
                textBox1.Clear();
            }
            else{
                MessageBox.Show("Personel Bulunamadı!");
                con.Close();
                textBox1.Clear();
            }
            
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelislemleri geri = new personelislemleri();
            this.Hide();
            geri.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
