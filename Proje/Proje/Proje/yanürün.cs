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
    public partial class yanürün : Form
    {
        public yanürün()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            comboBox2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenü geri6 = new anamenü();
            this.Hide();
            geri6.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            comboBox4.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            comboBox5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü geri7 = new anamenü();
            this.Hide();
            geri7.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
