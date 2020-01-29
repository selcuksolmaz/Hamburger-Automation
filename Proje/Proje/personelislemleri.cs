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
    public partial class personelislemleri : Form
    {
        public personelislemleri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelKaydı pkaydi = new PersonelKaydı();
            this.Hide();
            pkaydi.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            psil sil = new psil();
            this.Hide();
            sil.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminpaneli geri = new adminpaneli();
            this.Hide();
            geri.Show();

        }
    }
}
