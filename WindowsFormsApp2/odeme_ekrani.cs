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
    public partial class odeme_ekrani : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public odeme_ekrani()
        {
            InitializeComponent();
        }

        private void odeme_ekrani_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'marketDataSet.müsteri1' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.müsteri1TableAdapter.Fill(this.marketDataSet.müsteri1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = richTextBox1.Text;
            con = new SqlConnection("Data Source=ALEYY;Initial Catalog=market;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from müsteri1 where müsteri_no = '" + richTextBox1.Text + "'";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Müşteri bulundu. ");
                Form2 fr2 = new Form2();
                fr2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Hatalı giris. Müşteri bulunamadı.");
            }
            con.Close();
        }
    }
}
