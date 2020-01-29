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
    public partial class fiyat : Form
    {
        public fiyat()
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
            label3.Text = cmd.ExecuteScalar().ToString();
            con.Close();

        }
        private void verileriGoster()
        {
            idnumber();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From sipariş where ID=@id";
            cmd.Parameters.AddWithValue("@id", (Convert.ToInt32(label3.Text)));
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Menü"].ToString();
                ekle.SubItems.Add(dr["büyükküçük"].ToString());
                ekle.SubItems.Add(dr["icecek"].ToString());
                ekle.SubItems.Add(dr["tatlı"].ToString());

                listView1.Items.Add(ekle);



            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menütatlı geri = new menütatlı();
            this.Hide();
            geri.Show();
        }

        private void fiyat_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            verileriGoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
