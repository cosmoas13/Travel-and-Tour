namespace AzureDevK
{
    partial class frmDatKend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatKend));
            this.button4 = new System.Windows.Forms.Button();
            this.txtIdMobil = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lvView = new System.Windows.Forms.ListView();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtTipeMobil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtNamaMobil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(276, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(18, 22);
            this.button4.TabIndex = 25;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // txtIdMobil
            // 
            this.txtIdMobil.Location = new System.Drawing.Point(181, 38);
            this.txtIdMobil.Name = "txtIdMobil";
            this.txtIdMobil.Size = new System.Drawing.Size(78, 20);
            this.txtIdMobil.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "ID Mobil";
            // 
            // txtCari
            // 
            this.txtCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCari.Location = new System.Drawing.Point(30, 158);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(573, 20);
            this.txtCari.TabIndex = 16;
            this.txtCari.Text = "Masukkan Kata Kunci Pencarian.....";
            this.txtCari.Click += new System.EventHandler(this.txtCari_Click);
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged_1);
            this.txtCari.Leave += new System.EventHandler(this.txtCari_Leave);
            // 
            // lvView
            // 
            this.lvView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvView.Location = new System.Drawing.Point(30, 197);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(573, 263);
            this.lvView.TabIndex = 15;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.DoubleClick += new System.EventHandler(this.lvView_DoubleClick);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(422, 89);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(124, 44);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(422, 25);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(124, 44);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // txtTipeMobil
            // 
            this.txtTipeMobil.Location = new System.Drawing.Point(181, 93);
            this.txtTipeMobil.Name = "txtTipeMobil";
            this.txtTipeMobil.Size = new System.Drawing.Size(151, 20);
            this.txtTipeMobil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipe";
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.dtTanggal);
            this.gb1.Controls.Add(this.button4);
            this.gb1.Controls.Add(this.txtIdMobil);
            this.gb1.Controls.Add(this.label11);
            this.gb1.Controls.Add(this.txtCari);
            this.gb1.Controls.Add(this.lvView);
            this.gb1.Controls.Add(this.btnBatal);
            this.gb1.Controls.Add(this.btnSimpan);
            this.gb1.Controls.Add(this.txtNamaMobil);
            this.gb1.Controls.Add(this.txtTipeMobil);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(116, 69);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(623, 476);
            this.gb1.TabIndex = 6;
            this.gb1.TabStop = false;
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(181, 120);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(151, 20);
            this.dtTanggal.TabIndex = 26;
            // 
            // txtNamaMobil
            // 
            this.txtNamaMobil.Location = new System.Drawing.Point(181, 65);
            this.txtNamaMobil.Name = "txtNamaMobil";
            this.txtNamaMobil.Size = new System.Drawing.Size(151, 20);
            this.txtNamaMobil.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahun Keluaran";
            // 
            // frmDatKend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 474);
            this.Controls.Add(this.gb1);
            this.MinimizeBox = false;
            this.Name = "frmDatKend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatKend";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatKend_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtIdMobil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtTipeMobil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtNamaMobil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTanggal;
    }
}