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
    public partial class FormTransaksi : Form
    {
        //membuat koneksi database
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-44L09114\SQLEXPRESS;Initial Catalog=AppRentalMobil;Integrated Security=True");
        // Tambahkan Variabel untuk perintah sql
        SqlDataAdapter adapt;
        private SqlCommand cmd;


        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            //prosedure menghapus data
            textboxidtransaksi.Text = "";
            textboxlamasewa.Text = "0";
            datetglsewa.Value = DateTime.Now;
            textboxidpelanggan2.Text = "";
            textboxnomobil2.Text = "";

        }

        private void DisplayData()
        {
            //Membuka koneksi
            con.Open();
            //Membuat variabel dt
            DataTable dt = new DataTable();
            //Mengambil data tabel dbo untuk ditampilkan
            adapt = new SqlDataAdapter("select *From dbo.data_transaksi", con);
            adapt.Fill(dt);
            //menampilkan data di GrideView
            dgv_transaksi.DataSource = dt;
            //menutup koneksi
            con.Close();
        }

        public void FormDataPelanggan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //menutup form
            FormMainMenu tutup = new FormMainMenu();
            tutup.Show();
            this.Hide();

        }



        private void btnproses_Click(object sender, EventArgs e)
        {

            //membuat kondisi if else
            if (textboxidtransaksi.Text != "" && textboxlamasewa.Text != "" && datetglsewa.Text != "" && textboxnomobil2.Text != "" && textboxidpelanggan2.Text != "") ;
            {
                //menambah table dbo ke Table masing masing
                cmd = new SqlCommand("insert into dbo.data_transaksi (id_transaksi,lama_sewa,tanggal_sewa,nomor_mobil,id_pelanggan) values(@idtransaksi,@lamasewa,@tglsewa,nomormobil,idpel)", con);

                //membuka koneksi
                cmd.Parameters.AddWithValue("@idpelanggan", textboxidpelanggan.Text);
                cmd.Parameters.AddWithValue("@namapelanggan", textboxnamapelanggan.Text);
                cmd.Parameters.AddWithValue("@nokotak", textboxnokotak.Text);
                cmd.Parameters.AddWithValue("@harga", textboxalamat.Text);
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

        private void textboxcaritransaksi_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-44L09114\SQLEXPRESS;Initial Catalog=AppRentalMobil;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from dbo.data_transaksi where id_transaksi='" + textboxcaritransaksi + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_transaksi.DataSource = dt;
            con.Close();


        }


        private void textboxlamasewa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textboxidtransaksi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxnomobil2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxidpelanggan2_TextChanged(object sender, EventArgs e)
        {

        }

        private void datetglsewa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_transaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
