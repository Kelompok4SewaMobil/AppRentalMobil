using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiRentalMobil
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void transToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        // Menampilkan form data mobil
        private void inputDataMobilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataMobil tampil = new FormDataMobil();
            tampil.Show();
            this.Hide();
        }

        // Menampilkan form data pelanggan
        private void inputDataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataPelanggan tampil = new FormDataPelanggan();
            tampil.Show();
            this.Hide();
        }

        // menutup aplikasi
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin Menutup Aplikasi ?", "Exit App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        //Menampilkan form Transaksi
        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi tampil = new FormTransaksi();
            tampil.Show();
            this.Hide();
        }
    }
}
