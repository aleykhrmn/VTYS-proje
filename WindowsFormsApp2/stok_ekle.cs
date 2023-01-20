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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class stok_ekle : Form
    {
        public stok_ekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALEYY;Initial Catalog=market;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into stok(uKodu,uAdeti,alışFiyatı,satışFiyatı) values(@uKod,@uAdeti,@alışFiyatı,@satışFiyatı)");
            komut.Parameters.AddWithValue("@uKod", textBox1.Text);
            komut.Parameters.AddWithValue("@uAdeti", textBox3.Text);
            komut.Parameters.AddWithValue("@alışFiyatı", textBox4.Text);
            komut.Parameters.AddWithValue("@satışFiyatı", textBox5.Text);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            MessageBox.Show("Stok eklendi.");
            baglanti.Close();
            foreach (Control item in this.Controls)
            {
                if (item is RichTextBox )
                {
                    item.Text = " ";
                }

            }
        }
    }
}
