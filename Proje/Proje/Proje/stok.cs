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
    public partial class stok : Form
    {
        public stok()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=stok.mdb");
        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DataSet ds;
        void listele()
        {
            con.Open();
            da = new OleDbDataAdapter("Select* from adet", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();


        }
        private void button3_Click(object sender, EventArgs e)
        {
            adminpaneli geri = new adminpaneli();
            geri.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void stok_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Bilgileri Eksik Girdiniz");
            }

            else
            {
                con.Open();
                string sorgu = "insert into adet(yiyecek_adi,sayisi) values (@adi,@sayi)";
                cmd = new OleDbCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@sayi", textBox2.Text);
                

                cmd.ExecuteNonQuery();
                con.Close();

                listele();
            }
            textBox1.Clear();
            textBox2.Clear();
            


        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {

                string sorgu = "Update adet Set yiyecek_adi=@adi,sayisi=@sayi Where id=@Id";
                cmd = new OleDbCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@adi", textBox1.Text);
                cmd.Parameters.AddWithValue("@sayi", textBox2.Text);
               
                cmd.Parameters.AddWithValue("@Id", (dataGridView1.CurrentRow.Cells[0].Value));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                listele();
                textBox1.Clear();
                textBox2.Clear();
                
            }
            catch
            {
                MessageBox.Show("Ürün Bulunamadı");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "Delete From adet Where sayisi=@sayisi";
                cmd = new OleDbCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@sayisi", textBox2.Text );
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                listele();
                textBox1.Clear();
                textBox2.Clear();
                

            }
            catch
            {
                MessageBox.Show("Veri Bulunamadı!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            adminpaneli geri = new adminpaneli();
            this.Hide();
            geri.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }






}

