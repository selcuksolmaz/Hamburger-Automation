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
        OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stok.mdb");
        OleDbDataReader dr,dr2;
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
            listView1.Items.Clear();
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From sipariş";
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
        private void veriaktar()
        {


            for (int i = 0; i < listView1.Items.Count; i++)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into tsipariş (Menü,m_fiyat,büyükküçük,bk_fiyat,icecek,tatlı,t_fiyat,toplamfiyat) values ('" + listView1.Items[i].SubItems[0].Text + "','" + Convert.ToDouble(listView1.Items[i].SubItems[1].Text) + "','" + listView1.Items[i].SubItems[2].Text + "','" + Convert.ToDouble(listView1.Items[i].SubItems[3].Text) + "','" + listView1.Items[i].SubItems[4].Text + "','" + listView1.Items[i].SubItems[5].Text + "','" + Convert.ToDouble(listView1.Items[i].SubItems[6].Text) + "','" + Convert.ToDouble(listView1.Items[i].SubItems[7].Text) + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void toplam_fiyat()
        {
            double sum = 0;
            for(int i=0;i<listView1.Items.Count;i++)
            {
                sum = sum + Convert.ToDouble(listView1.Items[i].SubItems[7].Text);
            }
            label4.Text = Convert.ToString(sum);
        }
        private void stokdurumu()
        {
            idnumber();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from sipariş where ID =@id ", con);
            cmd.Parameters.AddWithValue("@id", label3.Text.ToString());
            dr = cmd.ExecuteReader();
            while(dr.Read())
                {
                label5.Text= dr["Menü"].ToString();
                label6.Text = dr["icecek"].ToString();
                label7.Text = dr["tatlı"].ToString();
            }
            con.Close();
            con2.Open();
            OleDbCommand cmd2 = new OleDbCommand("select * from adet where isim='"+label5.Text+"' ", con2);
            dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                label8.Text = dr2["stoksayısı"].ToString();
            }
            
            con2.Close();
            con2.Open();
            OleDbCommand cmd3 = new OleDbCommand("select * from adet where isim='" + label6.Text + "' ", con2);
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                label9.Text = dr2["stoksayısı"].ToString();
            }

            con2.Close();

            con2.Open();
            OleDbCommand cmd4 = new OleDbCommand("select * from adet where isim='" + label7.Text + "' ", con2);
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                label10.Text = dr2["stoksayısı"].ToString();
            }

            con2.Close();


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
            toplam_fiyat();
            stokdurumu();
            label14.Visible = true;
            label4.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idnumber();
            OleDbCommand cmd = new OleDbCommand("delete from sipariş", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            veriaktar();
            stokdurumu();
            

            

            

            

            MessageBox.Show("Teşekkürler! Afiyet Olsun Yine Bekleriz");
            OleDbCommand cmd2 = new OleDbCommand("delete from sipariş", con);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();

          
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            anamenü anaekran = new anamenü();
            this.Hide();
            anaekran.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
