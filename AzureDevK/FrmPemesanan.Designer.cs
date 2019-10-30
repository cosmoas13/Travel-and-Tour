namespace AzureDevK
{
    partial class FrmPemesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPemesanan));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHargaPaket = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cmbPaket = new System.Windows.Forms.ComboBox();
            this.txtKdUser = new System.Windows.Forms.TextBox();
            this.txtKdPaket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtBerangkat = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.nmTiket = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNoPem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.btnCancel);
            this.gb1.Controls.Add(this.btnSave);
            this.gb1.Controls.Add(this.groupBox2);
            this.gb1.Location = new System.Drawing.Point(99, 84);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(532, 588);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 47);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(94, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtHargaPaket);
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Controls.Add(this.cmbPaket);
            this.groupBox2.Controls.Add(this.txtKdUser);
            this.groupBox2.Controls.Add(this.txtKdPaket);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtBerangkat);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nmTiket);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtTanggal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNoPem);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(65, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 468);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pemesanan";
            // 
            // txtHargaPaket
            // 
            this.txtHargaPaket.Location = new System.Drawing.Point(167, 239);
            this.txtHargaPaket.Name = "txtHargaPaket";
            this.txtHargaPaket.Size = new System.Drawing.Size(121, 20);
            this.txtHargaPaket.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(294, 148);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(29, 23);
            this.btnAddUser.TabIndex = 22;
            this.btnAddUser.Text = "+";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cmbPaket
            // 
            this.cmbPaket.FormattingEnabled = true;
            this.cmbPaket.Location = new System.Drawing.Point(167, 178);
            this.cmbPaket.Name = "cmbPaket";
            this.cmbPaket.Size = new System.Drawing.Size(144, 21);
            this.cmbPaket.TabIndex = 4;
            this.cmbPaket.SelectedIndexChanged += new System.EventHandler(this.cmbPaket_SelectedIndexChanged);
            // 
            // txtKdUser
            // 
            this.txtKdUser.Location = new System.Drawing.Point(167, 150);
            this.txtKdUser.Name = "txtKdUser";
            this.txtKdUser.Size = new System.Drawing.Size(99, 20);
            this.txtKdUser.TabIndex = 21;
            // 
            // txtKdPaket
            // 
            this.txtKdPaket.Location = new System.Drawing.Point(167, 210);
            this.txtKdPaket.Name = "txtKdPaket";
            this.txtKdPaket.Size = new System.Drawing.Size(89, 20);
            this.txtKdPaket.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Paket";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Kode User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Paket";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(293, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilihan Paket";
            // 
            // dtBerangkat
            // 
            this.dtBerangkat.Location = new System.Drawing.Point(167, 298);
            this.dtBerangkat.Name = "dtBerangkat";
            this.dtBerangkat.Size = new System.Drawing.Size(185, 20);
            this.dtBerangkat.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tgl Berangkat";
            // 
            // nmTiket
            // 
            this.nmTiket.Location = new System.Drawing.Point(166, 328);
            this.nmTiket.Name = "nmTiket";
            this.nmTiket.Size = new System.Drawing.Size(53, 20);
            this.nmTiket.TabIndex = 11;
            this.nmTiket.ValueChanged += new System.EventHandler(this.nmTiket_ValueChanged);
            this.nmTiket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nmTiket_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Jumlah Tiket";
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(166, 269);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(185, 20);
            this.dtTanggal.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tanggal Pesan";
            // 
            // txtNoPem
            // 
            this.txtNoPem.Location = new System.Drawing.Point(166, 124);
            this.txtNoPem.Name = "txtNoPem";
            this.txtNoPem.Size = new System.Drawing.Size(121, 20);
            this.txtNoPem.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "No Pemesanan";
            // 
            // FrmPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(731, 703);
            this.Controls.Add(this.gb1);
            this.MaximizeBox = false;
            this.Name = "FrmPemesanan";
            this.Text = "FrmPemesanan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPemesanan_Load);
            this.gb1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTiket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nmTiket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNoPem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHargaPaket;
        private System.Windows.Forms.ComboBox cmbPaket;
        private System.Windows.Forms.TextBox txtKdPaket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBerangkat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtKdUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddUser;
    }
}