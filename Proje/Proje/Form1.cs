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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sipariş.mdb");
        OleDbDataReader dr;
        DataSet ds;
        private void verileriGoster()
        {
            listView1.Items.Clear();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From tsipariş";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Menü"].ToString();
                ekle.SubItems.Add(dr["m_fiyat"].ToString());
                ekle.SubItems.Add(dr["büyükküçük"].ToString());
                ekle.SubItems.Add(dr["bk_fiyat"].ToString());
                ekle.SubItems.Add(dr["icecek"].ToString());
                ekle.SubItems.Add(dr["tatlı"].ToString());
                ekle.SubItems.Add(dr["t_fiyat"].ToString());
                ekle.SubItems.Add(dr["toplamfiyat"].ToString());

                listView1.Items.Add(ekle);



            }
            con.Close();
        }

        private void toplam_fiyat()
        {
            double sum = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sum = sum + Convert.ToDouble(listView1.Items[i].SubItems[7].Text);
            }
            label4.Text = Convert.ToString(sum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            verileriGoster();
            toplam_fiyat();
            label14.Visible = true;
            label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminpaneli geri = new adminpaneli();
            geri.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
