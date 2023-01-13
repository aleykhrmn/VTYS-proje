using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection baglanti = new SqlConnection("Data Source=ALEYY;Initial Catalog=market;Integrated Security=True");
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

        private void stokBilgiGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stok_bilgi stb = new stok_bilgi();
            stb.ShowDialog();
        }

        private void veresiyeSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            veresiye_satis vst = new veresiye_satis();
            vst.ShowDialog();
        }

        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteri_ekle musteri_ekle = new musteri_ekle();
            musteri_ekle.ShowDialog();
        }

        private void müşteriListaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            musteri_listele musteri_listele = new musteri_listele();
            musteri_listele.ShowDialog();
        }
    }
}
