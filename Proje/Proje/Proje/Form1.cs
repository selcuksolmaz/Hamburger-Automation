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
            
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From sipariş";
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

        private void button4_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }
    }
}
