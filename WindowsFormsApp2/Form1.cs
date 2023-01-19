using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void member_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = richTextBox1.Text;
            string password = richTextBox2.Text;
            con = new SqlConnection("Data Source=ALEYY;Initial Catalog=market;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from login1 where kullanici_adi= '" + richTextBox1.Text + "' And sifre = '" + richTextBox2.Text + "'";

            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Başarılı ");
                Form2 fr2 = new Form2();
                fr2.ShowDialog();

            }
            else
            {
                MessageBox.Show("Hatalı giris");
            }
            con.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
