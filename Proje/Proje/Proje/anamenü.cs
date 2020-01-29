using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class anamenü : Form
    {
        public anamenü()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer3.Interval = 1000;
            timer3.Start();
            label9.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menüler menüler = new menüler();
            menüler.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            cocukmenü cocukmenü = new cocukmenü();
            cocukmenü.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (panel1.Width == 0)
            {
                timer1.Start();
            }
            else
            {
                timer2.Start();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            yanürün yanurun = new yanürün();
            yanurun.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tatlılar tatli = new tatlılar();
            tatli.Show();
            this.Hide();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            icecek icecek = new icecek();
            icecek.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            soslar soslar = new soslar();
            this.Hide();
            soslar.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 5;
            if (panel1.Width == 160)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Width -= 5;
            if (panel1.Width == 0)
            {
                timer2.Stop();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            girişpaneli geri = new girişpaneli();
            geri.Show();
            this.Hide();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
