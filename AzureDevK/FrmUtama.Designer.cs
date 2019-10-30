namespace AzureDevK
{
    partial class FrmUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUtama));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnLgout = new System.Windows.Forms.Button();
            this.btnDPenjualan = new System.Windows.Forms.Button();
            this.btnDKendaraan = new System.Windows.Forms.Button();
            this.btnPemesanan = new System.Windows.Forms.Button();
            this.btnDTravel = new System.Windows.Forms.Button();
            this.btnDbPel = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb1.BackgroundImage")));
            this.gb1.Controls.Add(this.btnLgout);
            this.gb1.Controls.Add(this.btnDPenjualan);
            this.gb1.Controls.Add(this.btnDKendaraan);
            this.gb1.Controls.Add(this.btnPemesanan);
            this.gb1.Controls.Add(this.btnDTravel);
            this.gb1.Controls.Add(this.btnDbPel);
            this.gb1.Location = new System.Drawing.Point(98, 32);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(682, 366);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            // 
            // btnLgout
            // 
            this.btnLgout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLgout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLgout.BackgroundImage")));
            this.btnLgout.Location = new System.Drawing.Point(447, 219);
            this.btnLgout.Name = "btnLgout";
            this.btnLgout.Size = new System.Drawing.Size(158, 130);
            this.btnLgout.TabIndex = 5;
            this.btnLgout.UseVisualStyleBackColor = false;
            this.btnLgout.Click += new System.EventHandler(this.btnLgout_Click);
            // 
            // btnDPenjualan
            // 
            this.btnDPenjualan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDPenjualan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDPenjualan.BackgroundImage")));
            this.btnDPenjualan.Location = new System.Drawing.Point(447, 19);
            this.btnDPenjualan.Name = "btnDPenjualan";
            this.btnDPenjualan.Size = new System.Drawing.Size(158, 130);
            this.btnDPenjualan.TabIndex = 4;
            this.btnDPenjualan.UseVisualStyleBackColor = false;
            this.btnDPenjualan.Click += new System.EventHandler(this.btnDPenjualan_Click);
            // 
            // btnDKendaraan
            // 
            this.btnDKendaraan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDKendaraan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDKendaraan.BackgroundImage")));
            this.btnDKendaraan.Location = new System.Drawing.Point(260, 219);
            this.btnDKendaraan.Name = "btnDKendaraan";
            this.btnDKendaraan.Size = new System.Drawing.Size(158, 130);
            this.btnDKendaraan.TabIndex = 3;
            this.btnDKendaraan.UseVisualStyleBackColor = false;
            this.btnDKendaraan.Click += new System.EventHandler(this.btnDKendaraan_Click);
            // 
            // btnPemesanan
            // 
            this.btnPemesanan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPemesanan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPemesanan.BackgroundImage")));
            this.btnPemesanan.Location = new System.Drawing.Point(260, 19);
            this.btnPemesanan.Name = "btnPemesanan";
            this.btnPemesanan.Size = new System.Drawing.Size(158, 130);
            this.btnPemesanan.TabIndex = 2;
            this.btnPemesanan.UseVisualStyleBackColor = false;
            this.btnPemesanan.Click += new System.EventHandler(this.btnPemesanan_Click);
            // 
            // btnDTravel
            // 
            this.btnDTravel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDTravel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDTravel.BackgroundImage")));
            this.btnDTravel.Location = new System.Drawing.Point(71, 219);
            this.btnDTravel.Name = "btnDTravel";
            this.btnDTravel.Size = new System.Drawing.Size(158, 130);
            this.btnDTravel.TabIndex = 1;
            this.btnDTravel.UseVisualStyleBackColor = false;
            this.btnDTravel.Click += new System.EventHandler(this.btnDTravel_Click);
            // 
            // btnDbPel
            // 
            this.btnDbPel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDbPel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDbPel.BackgroundImage")));
            this.btnDbPel.Location = new System.Drawing.Point(71, 19);
            this.btnDbPel.Name = "btnDbPel";
            this.btnDbPel.Size = new System.Drawing.Size(158, 130);
            this.btnDbPel.TabIndex = 0;
            this.btnDbPel.UseVisualStyleBackColor = false;
            this.btnDbPel.Click += new System.EventHandler(this.btnDbPel_Click_1);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 501);
            this.Controls.Add(this.gb1);
            this.IsMdiContainer = true;
            this.Name = "FrmUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUtama_Load);
            this.gb1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnLgout;
        private System.Windows.Forms.Button btnDPenjualan;
        private System.Windows.Forms.Button btnDKendaraan;
        private System.Windows.Forms.Button btnPemesanan;
        private System.Windows.Forms.Button btnDTravel;
        private System.Windows.Forms.Button btnDbPel;
    }
}