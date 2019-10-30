namespace AzureDevK
{
    partial class frmDatTrav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatTrav));
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtKdTravel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lvView = new System.Windows.Forms.ListView();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.gb1.Controls.Add(this.button4);
            this.gb1.Controls.Add(this.txtKdTravel);
            this.gb1.Controls.Add(this.label11);
            this.gb1.Controls.Add(this.txtCari);
            this.gb1.Controls.Add(this.lvView);
            this.gb1.Controls.Add(this.btnBatal);
            this.gb1.Controls.Add(this.btnSimpan);
            this.gb1.Controls.Add(this.txtHarga);
            this.gb1.Controls.Add(this.txtNama);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(116, 69);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(609, 481);
            this.gb1.TabIndex = 4;
            this.gb1.TabStop = false;
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
            // txtKdTravel
            // 
            this.txtKdTravel.Location = new System.Drawing.Point(158, 41);
            this.txtKdTravel.Name = "txtKdTravel";
            this.txtKdTravel.Size = new System.Drawing.Size(78, 20);
            this.txtKdTravel.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "kode Travel";
            // 
            // txtCari
            // 
            this.txtCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCari.Location = new System.Drawing.Point(16, 137);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(573, 20);
            this.txtCari.TabIndex = 16;
            this.txtCari.Text = "Masukkan Kata Kunci Pencarian.....";
            this.txtCari.Click += new System.EventHandler(this.txtCari_Click);
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // lvView
            // 
            this.lvView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvView.Location = new System.Drawing.Point(16, 163);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(573, 299);
            this.lvView.TabIndex = 15;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.DoubleClick += new System.EventHandler(this.lvView_DoubleClick);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(389, 78);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(124, 42);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(389, 28);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(124, 44);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(158, 93);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(151, 20);
            this.txtHarga.TabIndex = 9;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
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
            this.label5.Location = new System.Drawing.Point(77, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Travel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Travel";
            // 
            // frmDatTrav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(961, 627);
            this.Controls.Add(this.gb1);
            this.Name = "frmDatTrav";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatTrav";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatTrav_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtKdTravel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHarga;
    }
}