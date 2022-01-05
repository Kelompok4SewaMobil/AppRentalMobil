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
    public partial class FormDataMobil : Form
    {
        //membuat koneksi database
         SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-44L09114\SQLEXPRESS;Initial Catalog=AppRentalMobil;Integrated Security=True");
         SqlCommand cmd;
         SqlDataAdapter adapt;
        //variabel menghapus dan menambh data
        public string nomobil = "";


        public FormDataMobil()
        {
            InitializeComponent();
            DisplayData();
        }


        //Menutup form
        private void FormDataMobil_FormClosed(object sender, EventArgs e)
        {
            FormMainMenu tutup = new FormMainMenu();
            tutup.Show();
            this.Hide();
        }




        private void btnsave_Click(object sender, EventArgs e)
        {
            //membuat kondisi if else
            if (textboxnomobil.Text != "" && textboxjenismobil.Text != "" && textboxmerkmobil.Text != "" && textboxhargasewa.Text != "0")
            {
                //menambah table dbo ke Table masing masing
                cmd = new SqlCommand("insert into dbo.data_mobil (nomor_mobil,jenis_mobil,merk_mobil,harga_sewa) values(@nomobil,@jenismobil,@merk,@harga)", con);

                //membuka koneksi
                cmd.Parameters.AddWithValue("@nomobil", textboxnomobil.Text);
                cmd.Parameters.AddWithValue("@jenismobil", textboxjenismobil.Text);
                cmd.Parameters.AddWithValue("@merk", textboxmerkmobil.Text);
                cmd.Parameters.AddWithValue("@harga", textboxhargasewa.Text);
                cmd.ExecuteNonQuery();

                //menutup koneksi
                con.Close();

                //menampilkan pesan data berhasil ditambahkan
                MessageBox.Show("Data Berhasil Ditambahkan Boss");
                //memanggil Prosedur display data
                DisplayData();
                //memanggil prosedur Clear data
                ClearData();
            }

            else
            {
                //Menampilkan pesan belum terisi
                MessageBox.Show("Kolom Belum Terisi");
            }
            
        }

        // Display data untuk GrideView
        private void DisplayData()
        {
            //Membuka koneksi
            con.Open();
            //Membuat variabel dt
            DataTable dt = new DataTable();
            //Mengambil data tabel dbo untuk ditampilkan
            adapt = new SqlDataAdapter("select *From dbo.data_mobil", con);
            adapt.Fill(dt);
            //menampilkan data di GrideView
            dataGridView1.DataSource = dt;
            //menutup koneksi
            con.Close();
        }
        private void ClearData()
        {
            //prosedure menghapus data
            textboxnomobil.Text = "";
            textboxjenismobil.Text = "";
            textboxmerkmobil.Text = "";
            textboxhargasewa.Text = "";
            nomobil = "";

        }

        //update data
        //membuat button edit
        private void btnedit_Click(object sender, EventArgs e)
        {
            //membuat kondisi if else
            if (textboxnomobil.Text!= "" && textboxjenismobil.Text != "" && textboxmerkmobil.Text != "" && textboxhargasewa.Text!= "0")
            {
                //mendefinisikan table data mobil dan kolom untuk update data
                cmd = new SqlCommand("update dbo.data_mobil set nomor_mobil =@nomobil,jenis_mobil=@jnsmobil,merk_mobil=@merk,harga_sewa=@hrg where nomor_mobil=@nomob12)", con);
                //membuka koneksi
                con.Open();
                //mengirim data hasil input
                cmd.Parameters.AddWithValue("@nomobil2", nomobil);
                cmd.Parameters.AddWithValue("@nomobil",  textboxnomobil);
                cmd.Parameters.AddWithValue("@jnsmobil", textboxjenismobil.Text);
                cmd.Parameters.AddWithValue("@merk", textboxmerkmobil.Text);
                cmd.Parameters.AddWithValue("@hrg", textboxhargasewa.Text);
                cmd.ExecuteNonQuery();

                //menampilkan data berhasil diubah
                MessageBox.Show("Data Berhasil Diubah");
                //menutup koneksi
                con.Close();
                //memanggil display data
                DisplayData();
                //memanggil clear data
                ClearData();

            }
            else
            {
                MessageBox.Show("Pleasee select Record to edit");
            }
        }


        //Membuat Button Delete
        private void btndelete_Click(object sender, EventArgs e)
        {
            //membuat kondisi if else
            if (nomobil != "") 
            {
                cmd = new SqlCommand("delete dbo.data_mobil where nomor_mobil= @nomobil", con);
                //membuka koneksi
                con.Open();
                //mengirim data nomor mobil
                cmd.Parameters.AddWithValue("@nomobil2", nomobil);
                cmd.ExecuteNonQuery();
                //menutup koneksi
                con.Close();
                //menampilkan pesan data berhasil dihapus
                MessageBox.Show("Data berhasil dihapus");
                //memanggil prosedur Display Data
                DisplayData();
                //menghapus data
                ClearData();
            }
            else
            {
                //menampilkan pesan
                MessageBox.Show("Please Select Record To delete");
            }

        }

        private void textboxnomobil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxjenismobil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxmerkmobil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxhargasewa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxcarinomobil_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //mengambil data dari form data mobil
            cmd.CommandText = "Select * Form dbo.data_mobil where nomor_mobil='" + textboxcarinomobil + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            //menampilkan data grideView
            dataGridView1.DataSource = dt;
            //menutup koneksi :)
            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomobil = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textboxnomobil.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textboxjenismobil.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textboxmerkmobil.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textboxhargasewa.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void FormDataMobil_Load(object sender, EventArgs e)
        {

        }
    }

    }

