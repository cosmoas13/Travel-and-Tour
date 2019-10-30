using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureDevK
{
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void FrmUtama_Load(object sender, EventArgs e)
        {
            gb1.Left = (this.ClientSize.Width - gb1.Width) / 2;
            gb1.Top = (this.ClientSize.Height - gb1.Height) / 2;
        }

        private void CheckActiveChildForm(Form FormControl, string FormExists)
        {
            int h = 0;
            if (MdiChildren.Count() > 0)
            {
                for (int i = 0; i < MdiChildren.Count(); i++)
                {
                    if (MdiChildren.ElementAt(i).Text == FormExists)
                    {
                        h = 1;
                        MessageBox.Show(FormExists + " masih aktif!", "Informasi!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MdiChildren.ElementAt(i).BringToFront();
                    }
                }
            }
            if (h == 0)
            {
                FormControl.MdiParent = this;
                FormControl.Show();
            }
        }

        private void btnLgout_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            var frmlogout = new FrmLogin();
            frmlogout.Closed += (s, args) => this.Close();
            frmlogout.Show();
            
        }

        private void btnDbPel_Click_1(object sender, EventArgs e)
        {
            FormPelanggan frmpelanggan = new FormPelanggan();
            CheckActiveChildForm(frmpelanggan, frmpelanggan.Text);
            gb1.Hide();
            frmpelanggan.Closed += (s, args) => gb1.Show();
        }

        private void btnPemesanan_Click(object sender, EventArgs e)
        {
            FrmPemesanan frmpemesanan = new FrmPemesanan();
            CheckActiveChildForm(frmpemesanan, frmpemesanan.Text);
            gb1.Hide();
            frmpemesanan.Closed += (s, args) => gb1.Show();
        }

        private void btnDPenjualan_Click(object sender, EventArgs e)
        {
            frmDetailPenjualan frmpenjualan = new frmDetailPenjualan();
            CheckActiveChildForm(frmpenjualan, frmpenjualan.Text);
            gb1.Hide();
            frmpenjualan.Closed += (s, args) => gb1.Show();
        }

        private void btnDTravel_Click(object sender, EventArgs e)
        {
            frmDatTrav frmdattrav = new frmDatTrav();
            CheckActiveChildForm(frmdattrav, frmdattrav.Text);
            gb1.Hide();
            frmdattrav.Closed += (s, args) => gb1.Show();
        }

        private void btnDKendaraan_Click(object sender, EventArgs e)
        {
            frmDatKend frmdatkend = new frmDatKend();
            CheckActiveChildForm(frmdatkend, frmdatkend.Text);
            gb1.Hide();
            frmdatkend.Closed += (s, args) => gb1.Show();
        }
    }
}
