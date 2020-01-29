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
    public partial class PersonelKaydı : Form
    {
        public PersonelKaydı()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=kullanici.mdb");
        
        OleDbDataReader dr;

        



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelislemleri geri = new personelislemleri();
            this.Hide();
            geri.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox4.Text == " ")
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz");
            else if(textBox6.Text == "" || textBox6.Text == " ")
                MessageBox.Show("Şifre Boş Bırakılamaz");
            else if(textBox1.Text == "" || textBox1.Text== " ")
                MessageBox.Show("İsim Boş Bırakılamaz");
            else if(textBox2.Text == "" || textBox2.Text == " ")
                MessageBox.Show("Soyisim Boş Bırakılamaz");
            else if(textBox3.Text == "" || textBox3.Text == " ")
                MessageBox.Show("Yaş Boş Bırakılamaz");
            else if(textBox5.Text == "" || textBox5.Text == " ")
                MessageBox.Show("E-posta Boş Bırakılamaz");
            else if(radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show("Lütfen Cinsiyet Seçiniz");
            else
            {
                string cinsiyet;
                if (radioButton1.Checked)
                {
                    cinsiyet = radioButton1.Text.ToString();
                }
                else
                {
                    cinsiyet = radioButton2.Text.ToString();
                }
                con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into kullanici (k_ad,k_sifre,Ad,Soyad,Yas,Cinsiyet,Eposta) values ('" + textBox4.Text.ToString() + "','" + textBox6.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + cinsiyet.ToString() + "','" + textBox5.Text.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Personel Kaydedildi");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox5.Clear();
            }

        }

        private void PersonelKaydı_Load(object sender, EventArgs e)
        {

        }
    }
}
