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
    public partial class adminpaneli : Form
    {
        public adminpaneli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelislemleri personelislemleri = new personelislemleri();
            this.Hide();
            personelislemleri.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            girişpaneli geri = new girişpaneli();
            this.Hide();
            geri.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString();
        }

        private void adminpaneli_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label9.Text = DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stok ileri = new stok();
            ileri.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
