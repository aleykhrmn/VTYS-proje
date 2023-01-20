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
    public partial class stoklar : Form
    {
        public stoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ALEYY;Initial Catalog=market;Integrated Security=True");
        DataSet daset = new DataSet();
        private void Stok_Göster_Load(object sender, EventArgs e)
        {
            Stok_Göster();
        }
        private void Stok_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from stok", baglanti);
            adtr.Fill(daset, "stok");
            dataGridView1.DataSource = daset.Tables["stok"];
            baglanti.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["uKod"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["uAdeti"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["alışFiyatı"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["satışFiyatı"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into stok(uKodu,uAdeti,alışFiyatı,satışFiyatı) values(@uKod,@uAdeti,@alışFiyatı,@satışFiyatı)");
            komut.Parameters.AddWithValue("@uKod", textBox1.Text);
            komut.Parameters.AddWithValue("@uAdeti", textBox2.Text);
            komut.Parameters.AddWithValue("@alışFiyatı", textBox3.Text);
            komut.Parameters.AddWithValue("@satışFiyatı", textBox3.Text);
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["uKodu"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["uAdeti"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["alışFiyatı"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["satışFiyatı"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["uKodu"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["uAdeti"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["alışFiyatı"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["satışFiyatı"].Value.ToString();
        }
    }
}
