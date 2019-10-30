namespace AzureDevK
{
    partial class FormPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPelanggan));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lvPelanggan = new System.Windows.Forms.ListView();
            this.button4 = new System.Windows.Forms.Button();
            this.txtKdUser = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.rdPerempuan = new System.Windows.Forms.RadioButton();
            this.rdLaki = new System.Windows.Forms.RadioButton();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.lvPelanggan);
            this.gb1.Controls.Add(this.button4);
            this.gb1.Controls.Add(this.txtKdUser);
            this.gb1.Controls.Add(this.label11);
            this.gb1.Controls.Add(this.txtCari);
            this.gb1.Controls.Add(this.btnBatal);
            this.gb1.Controls.Add(this.btnSimpan);
            this.gb1.Controls.Add(this.rdPerempuan);
            this.gb1.Controls.Add(this.rdLaki);
            this.gb1.Controls.Add(this.dtTanggal);
            this.gb1.Controls.Add(this.txtNoTelp);
            this.gb1.Controls.Add(this.txtEmail);
            this.gb1.Controls.Add(this.txtNama);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(116, 69);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(609, 554);
            this.gb1.TabIndex = 2;
            this.gb1.TabStop = false;
            // 
            // lvPelanggan
            // 
            this.lvPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPelanggan.Location = new System.Drawing.Point(20, 243);
            this.lvPelanggan.Name = "lvPelanggan";
            this.lvPelanggan.Size = new System.Drawing.Size(573, 294);
            this.lvPelanggan.TabIndex = 26;
            this.lvPelanggan.UseCompatibleStateImageBehavior = false;
            this.lvPelanggan.DoubleClick += new System.EventHandler(this.lvPelanggan_DoubleClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(253, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtKdUser
            // 
            this.txtKdUser.Location = new System.Drawing.Point(158, 41);
            this.txtKdUser.Name = "txtKdUser";
            this.txtKdUser.Size = new System.Drawing.Size(78, 20);
            this.txtKdUser.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Kode User";
            // 
            // txtCari
            // 
            this.txtCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCari.Location = new System.Drawing.Point(20, 216);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(573, 20);
            this.txtCari.TabIndex = 16;
            this.txtCari.Text = "Masukkan Kata Kunci Pencarian.....";
            this.txtCari.Click += new System.EventHandler(this.txtCari_Click);
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            this.txtCari.Leave += new System.EventHandler(this.txtCari_Leave);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(389, 116);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(124, 42);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(389, 66);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(124, 44);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // rdPerempuan
            // 
            this.rdPerempuan.AutoSize = true;
            this.rdPerempuan.Location = new System.Drawing.Point(253, 94);
            this.rdPerempuan.Name = "rdPerempuan";
            this.rdPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rdPerempuan.TabIndex = 12;
            this.rdPerempuan.TabStop = true;
            this.rdPerempuan.Text = "Perempuan";
            this.rdPerempuan.UseVisualStyleBackColor = true;
            this.rdPerempuan.CheckedChanged += new System.EventHandler(this.rdPerempuan_CheckedChanged);
            // 
            // rdLaki
            // 
            this.rdLaki.AutoSize = true;
            this.rdLaki.Location = new System.Drawing.Point(162, 93);
            this.rdLaki.Name = "rdLaki";
            this.rdLaki.Size = new System.Drawing.Size(74, 17);
            this.rdLaki.TabIndex = 11;
            this.rdLaki.TabStop = true;
            this.rdLaki.Text = "Laki - Laki";
            this.rdLaki.UseVisualStyleBackColor = true;
            this.rdLaki.CheckedChanged += new System.EventHandler(this.rdLaki_CheckedChanged);
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(158, 116);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(200, 20);
            this.dtTanggal.TabIndex = 10;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(158, 170);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.ShortcutsEnabled = false;
            this.txtNoTelp.Size = new System.Drawing.Size(151, 20);
            this.txtNoTelp.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 142);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(158, 67);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(151, 20);
            this.txtNama.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No Telepon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Lengkap ";
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 664);
            this.Controls.Add(this.gb1);
            this.MinimizeBox = false;
            this.Name = "FormPelanggan";
            this.Text = "FormPelanggan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPelanggan_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.RadioButton rdPerempuan;
        private System.Windows.Forms.RadioButton rdLaki;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtKdUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvPelanggan;
    }
}