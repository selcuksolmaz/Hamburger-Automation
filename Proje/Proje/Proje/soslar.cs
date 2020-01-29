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
    public partial class soslar : Form
    {
        public soslar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anamenü geridön2 = new anamenü();
            this.Hide();
            geridön2.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            anamenü geri = new anamenü();
            this.Hide();
            geri.Show();
        }
    }
}
