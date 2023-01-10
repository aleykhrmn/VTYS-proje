using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ödemeEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            odeme_ekrani ode = new odeme_ekrani();
            ode.ShowDialog();
        }

        private void ürünEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urun_ekle ure = new urun_ekle();
            ure.ShowDialog();
        }
    }
}
