
namespace AplikasiRentalMobil
{
    partial class FormMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataMobilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputDataPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transToolStripMenuItem,
            this.transaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transToolStripMenuItem
            // 
            this.transToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataMobilToolStripMenuItem,
            this.inputDataPelangganToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.transToolStripMenuItem.Name = "transToolStripMenuItem";
            this.transToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.transToolStripMenuItem.Text = "Menu";
            this.transToolStripMenuItem.Click += new System.EventHandler(this.transToolStripMenuItem_Click);
            // 
            // inputDataMobilToolStripMenuItem
            // 
            this.inputDataMobilToolStripMenuItem.Name = "inputDataMobilToolStripMenuItem";
            this.inputDataMobilToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.inputDataMobilToolStripMenuItem.Text = "Input Data Mobil";
            this.inputDataMobilToolStripMenuItem.Click += new System.EventHandler(this.inputDataMobilToolStripMenuItem_Click);
            // 
            // inputDataPelangganToolStripMenuItem
            // 
            this.inputDataPelangganToolStripMenuItem.Name = "inputDataPelangganToolStripMenuItem";
            this.inputDataPelangganToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.inputDataPelangganToolStripMenuItem.Text = "Input Data Pelanggan";
            this.inputDataPelangganToolStripMenuItem.Click += new System.EventHandler(this.inputDataPelangganToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataMobilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputDataPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
    }
}