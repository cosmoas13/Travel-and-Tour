namespace AzureDevK
{
    partial class PreviewDataPemesanan
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
            this.txtcaribar = new System.Windows.Forms.TextBox();
            this.lvpreviewpelanggan = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtcaribar
            // 
            this.txtcaribar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txtcaribar.Location = new System.Drawing.Point(12, 144);
            this.txtcaribar.Name = "txtcaribar";
            this.txtcaribar.Size = new System.Drawing.Size(596, 26);
            this.txtcaribar.TabIndex = 5;
            this.txtcaribar.Text = "Masukkan kata kunci pencarian......";
            this.txtcaribar.TextChanged += new System.EventHandler(this.txtcaribar_TextChanged);
            // 
            // lvpreviewpelanggan
            // 
            this.lvpreviewpelanggan.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.lvpreviewpelanggan.Location = new System.Drawing.Point(12, 176);
            this.lvpreviewpelanggan.Name = "lvpreviewpelanggan";
            this.lvpreviewpelanggan.Size = new System.Drawing.Size(596, 208);
            this.lvpreviewpelanggan.TabIndex = 6;
            this.lvpreviewpelanggan.UseCompatibleStateImageBehavior = false;
            this.lvpreviewpelanggan.DoubleClick += new System.EventHandler(this.lvpreviewpelanggan_DoubleClick);
            // 
            // PreviewDataPemesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 393);
            this.Controls.Add(this.txtcaribar);
            this.Controls.Add(this.lvpreviewpelanggan);
            this.Name = "PreviewDataPemesanan";
            this.Text = "PreviewDataPemesanan";
            this.Load += new System.EventHandler(this.PreviewDataPemesanan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcaribar;
        private System.Windows.Forms.ListView lvpreviewpelanggan;
    }
}