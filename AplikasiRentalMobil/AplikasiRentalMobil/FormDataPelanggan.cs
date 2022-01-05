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
    public partial class FormDataPelanggan : Form
    {
        //Membuat  koneksi ke database
        //membuat koneksi database
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-44L09114\SQLEXPRESS;Initial Catalog=AppRentalMobil;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public string id_pelanggan = "";


        public FormDataPelanggan()
        {
            InitializeComponent();
            
        }

        public void FormDataPelanggan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //menutup form
            FormMainMenu tutup = new FormMainMenu();
            tutup.Show();
            this.Hide();

        }


        private void FormDataPelanggan_Load(object sender, EventArgs e)
        {
            if (textboxidpelanggan.Text != "" && textboxnamapelanggan.Text != "" && textboxnokotak.Text != "" && textboxalamat.Text != "0")
            {
                //menambah table dbo ke Table masing masing
                cmd = new SqlCommand("insert into dbo.data_pelanggan (id_pelanggan,nama_pelanggan,nomor,kotak,alamat) values(@idpelanggan,@namapelanggan,@nokontak,@alamat)", con);

                //membuka koneksi
                con.Open();
                //mengirim input ke database
                cmd.Parameters.AddWithValue("@idpelanggan", textboxidpelanggan.Text);
                cmd.Parameters.AddWithValue("@namapelanggan", textboxnamapelanggan.Text);
                cmd.Parameters.AddWithValue("@nokotak", textboxnokotak.Text);
                cmd.Parameters.AddWithValue("@alamat", textboxalamat.Text);
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
                //Menampilkan pesan "Kolom belum terisi"
                MessageBox.Show("kolom belum terisi");

            }
        }
        private void DisplayData()
        {
            //Membuka koneksi
            con.Open();
            //Membuat variabel dt
            DataTable dt = new DataTable();
            //Mengambil data tabel dbo untuk ditampilkan
            adapt = new SqlDataAdapter("select *From dbo.data_pelanggan", con);
            adapt.Fill(dt);
            //menampilkan data di GrideView
            dgv.DataSource = dt;
            //menutup koneksi
            con.Close();
        }
        private void ClearData()
        {
            //prosedure menghapus data
            textboxidpelanggan.Text = "";
            textboxnamapelanggan.Text = "";
            textboxnokotak.Text = "";
            textboxalamat.Text = "";
            id_pelanggan = "";

        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            //membuat kondisi if else
            if (textboxidpelanggan.Text != "" && textboxnamapelanggan.Text != "" && textboxnokotak.Text != "" && textboxalamat.Text != "0")
            {
                //menambah table dbo ke Table masing masing
                cmd = new SqlCommand("insert into dbo.data_pelanggan (id_pelanggan,nama_pelanggan,nomor,kotak,alamat) values(@idpelanggan,@namapelanggan,@nokotak,@alamat)", con);

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

        private void btnedit_Click(object sender, EventArgs e)
        {

            //membuat kondisi if else
            if (textboxidpelanggan.Text != "" && textboxnamapelanggan.Text != "" && textboxnokotak.Text != "" && textboxalamat.Text != "0")
            {
                //mendefinisikan table data mobil dan kolom untuk update data
                cmd = new SqlCommand("update dbo.data_pelanggan set id_pelanggan=@idpelanggan,nama_pelanggan=@namapelanggan,nokontak,alamat=@alamat where id_pelanggan=@idpelanggan)", con);
                //membuka koneksi
                con.Open();
                //mengirim data hasil input
                cmd.Parameters.AddWithValue("@idpelanggan", id_pelanggan);
                cmd.Parameters.AddWithValue("@idpelanggan", textboxidpelanggan.Text);
                cmd.Parameters.AddWithValue("@namapelanggan", textboxnamapelanggan.Text);
                cmd.Parameters.AddWithValue("@nokotak", textboxnokotak.Text);
                cmd.Parameters.AddWithValue("@alamat", textboxalamat.Text);
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

    


      //Membuat progam delete
        private void btndelete_Click(object sender, EventArgs e)
        {
            //membuat kondisi if else
            if (id_pelanggan != "")
            {
                cmd = new SqlCommand("delete dbo.data_pelanggan where id_pelanggan=@idpelanggan", con);
                //membuka koneksi
                con.Open();
                //mengirim data nomor mobil
                cmd.Parameters.AddWithValue("@idpelanggan", id_pelanggan);
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

        private void textboxidpelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxnamapelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxnokotak_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxalamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxcari_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //mengambil data dari form data mobil
            cmd.CommandText = "Select * Form dbo.data_pelanggan where id_pelanggan='" + textboxcari + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            //menampilkan data grideView
            dgv.DataSource = dt;
            //menutup koneksi :)
            con.Close();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_pelanggan = (dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            textboxidpelanggan.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            textboxnamapelanggan.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            textboxnokotak.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            textboxalamat.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();

        }
    }
}
