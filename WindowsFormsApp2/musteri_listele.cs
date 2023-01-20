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
    public partial class musteri_listele : Form
    {
        public musteri_listele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALEYY;Initial Catalog=market;Integrated Security=True");
        DataSet daset = new DataSet();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void musteri_listele_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müsteri1", baglanti);
            adtr.Fill(daset, "müsteri1");
            dataGridView1.DataSource = daset.Tables["müsteri1"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["müsteri_no"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["müsteri_ad"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["müsteri_soyad"].Value.ToString();
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