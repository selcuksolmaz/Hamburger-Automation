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
    public partial class icecek2 : Form
    {
        public icecek2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            icecek geridön = new icecek();
            this.Hide();
            geridön.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            comboBox2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
        }

        private void icecek2_Load(object sender, EventArgs e)
        {

        }
    }
}
