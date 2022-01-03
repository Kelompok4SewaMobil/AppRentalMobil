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
        SqlConnection con = new SqlConnection("");
        SqlCommand cmd;
        SqlDataAdapter adapter;


        public string nomobil= "";


        public FormDataMobil()
        {
            InitializeComponent();
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }

    }

