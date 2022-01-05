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

namespace AplikasiRentalMobil
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Koneksi Database
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-44L09114\SQLEXPRESS;Initial Catalog=AppRentalMobil;Integrated Security=True");
            //Membuat Koneksi ke Tabel
            SqlDataAdapter sda = new SqlDataAdapter("select count (*) from login where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                FormMainMenu tampil = new FormMainMenu();
                tampil.Show();
            }
            else
            {
                MessageBox.Show("Mohon isi username dan password dengan benar", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

