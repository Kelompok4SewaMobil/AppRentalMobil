
namespace AplikasiRentalMobil
{
    partial class FormTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnproses = new System.Windows.Forms.Button();
            this.textboxlamasewa = new System.Windows.Forms.TextBox();
            this.textboxcaritransaksi = new System.Windows.Forms.TextBox();
            this.textboxidtransaksi = new System.Windows.Forms.TextBox();
            this.textboxnomobil2 = new System.Windows.Forms.TextBox();
            this.textboxidpelanggan2 = new System.Windows.Forms.TextBox();
            this.datetglsewa = new System.Windows.Forms.DateTimePicker();
            this.dgv_transaksi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Transaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lama Sewa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Sewa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "No Mobil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "ID Pelanggan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cari ID Transaksi";
            // 
            // btnproses
            // 
            this.btnproses.Location = new System.Drawing.Point(430, 203);
            this.btnproses.Name = "btnproses";
            this.btnproses.Size = new System.Drawing.Size(124, 39);
            this.btnproses.TabIndex = 7;
            this.btnproses.Text = "Proses";
            this.btnproses.UseVisualStyleBackColor = true;
            this.btnproses.Click += new System.EventHandler(this.btnproses_Click);
            // 
            // textboxlamasewa
            // 
            this.textboxlamasewa.Location = new System.Drawing.Point(183, 89);
            this.textboxlamasewa.Name = "textboxlamasewa";
            this.textboxlamasewa.Size = new System.Drawing.Size(200, 26);
            this.textboxlamasewa.TabIndex = 9;
            this.textboxlamasewa.TextChanged += new System.EventHandler(this.textboxlamasewa_TextChanged);
            // 
            // textboxcaritransaksi
            // 
            this.textboxcaritransaksi.Location = new System.Drawing.Point(633, 216);
            this.textboxcaritransaksi.Name = "textboxcaritransaksi";
            this.textboxcaritransaksi.Size = new System.Drawing.Size(164, 26);
            this.textboxcaritransaksi.TabIndex = 13;
            this.textboxcaritransaksi.TextChanged += new System.EventHandler(this.textboxcaritransaksi_TextChanged);
            // 
            // textboxidtransaksi
            // 
            this.textboxidtransaksi.Location = new System.Drawing.Point(183, 51);
            this.textboxidtransaksi.Name = "textboxidtransaksi";
            this.textboxidtransaksi.Size = new System.Drawing.Size(200, 26);
            this.textboxidtransaksi.TabIndex = 16;
            this.textboxidtransaksi.TextChanged += new System.EventHandler(this.textboxidtransaksi_TextChanged);
            // 
            // textboxnomobil2
            // 
            this.textboxnomobil2.Location = new System.Drawing.Point(183, 176);
            this.textboxnomobil2.Name = "textboxnomobil2";
            this.textboxnomobil2.Size = new System.Drawing.Size(200, 26);
            this.textboxnomobil2.TabIndex = 17;
            this.textboxnomobil2.TextChanged += new System.EventHandler(this.textboxnomobil2_TextChanged);
            // 
            // textboxidpelanggan2
            // 
            this.textboxidpelanggan2.Location = new System.Drawing.Point(183, 216);
            this.textboxidpelanggan2.Name = "textboxidpelanggan2";
            this.textboxidpelanggan2.Size = new System.Drawing.Size(200, 26);
            this.textboxidpelanggan2.TabIndex = 18;
            this.textboxidpelanggan2.TextChanged += new System.EventHandler(this.textboxidpelanggan2_TextChanged);
            // 
            // datetglsewa
            // 
            this.datetglsewa.Location = new System.Drawing.Point(183, 131);
            this.datetglsewa.Name = "datetglsewa";
            this.datetglsewa.Size = new System.Drawing.Size(200, 26);
            this.datetglsewa.TabIndex = 19;
            this.datetglsewa.ValueChanged += new System.EventHandler(this.datetglsewa_ValueChanged);
            // 
            // dgv_transaksi
            // 
            this.dgv_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaksi.Location = new System.Drawing.Point(59, 270);
            this.dgv_transaksi.Name = "dgv_transaksi";
            this.dgv_transaksi.RowHeadersWidth = 62;
            this.dgv_transaksi.RowTemplate.Height = 28;
            this.dgv_transaksi.Size = new System.Drawing.Size(738, 281);
            this.dgv_transaksi.TabIndex = 20;
            this.dgv_transaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_transaksi_CellContentClick);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 563);
            this.Controls.Add(this.dgv_transaksi);
            this.Controls.Add(this.datetglsewa);
            this.Controls.Add(this.textboxidpelanggan2);
            this.Controls.Add(this.textboxnomobil2);
            this.Controls.Add(this.textboxidtransaksi);
            this.Controls.Add(this.textboxcaritransaksi);
            this.Controls.Add(this.textboxlamasewa);
            this.Controls.Add(this.btnproses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnproses;
        private System.Windows.Forms.TextBox textboxlamasewa;
        private System.Windows.Forms.TextBox textboxcaritransaksi;
        private System.Windows.Forms.TextBox textboxidtransaksi;
        private System.Windows.Forms.TextBox textboxnomobil2;
        private System.Windows.Forms.TextBox textboxidpelanggan2;
        private System.Windows.Forms.DateTimePicker datetglsewa;
        private System.Windows.Forms.DataGridView dgv_transaksi;
    }
}