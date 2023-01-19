using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp2
{
    public partial class musteri_ekle : Form
    {
        public musteri_ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALEYY;Initial Catalog=market;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into müsteri1(müsteri_no,müsteri_ad,müsteri_soyad) values(@müsteri_no,@müsteri_ad,@müsteri_soyad)");
            komut.Parameters.AddWithValue("@müsteri_no", textBox1.Text);
            komut.Parameters.AddWithValue("@müsteri_ad", textBox2.Text);
            komut.Parameters.AddWithValue("@müsteri_soyad", textBox3.Text);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            MessageBox.Show("Yeni müşteri eklendi.");
            baglanti.Close();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }

            }
        }
    }
}
