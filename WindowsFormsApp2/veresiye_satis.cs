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
    public partial class veresiye_satis : Form
    {
        public veresiye_satis()
        {
            InitializeComponent();
        }

        private void veresiye_satis_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            musteri_ekle ekle = new musteri_ekle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            musteri_listele listele = new musteri_listele();
            listele.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            urun_listele u_listele = new urun_listele();
            u_listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            urun_ekle u_ekle = new  urun_ekle();
            u_ekle.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            satis_listele   satis_listele = new satis_listele();
            satis_listele.ShowDialog();
        }
    }
}
