using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AzureDevK
{
    public partial class FrmPemesanan : Form
    {
        Connection koneksi = new Connection();
        public FrmPemesanan()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void FrmPemesanan_Load(object sender, EventArgs e)
        {
            gb1.Left = (this.ClientSize.Width - gb1.Width) / 2;
            gb1.Top = (this.ClientSize.Height - gb1.Height) / 2;

            bersih();
        }

        private void bersih()
        {
            txtKdPaket.Clear();
            txtHargaPaket.Clear();
            txtNoPem.Clear();
            nmTiket.Value = 0;
            txtKdUser.Clear();
            txtKdPaket.MaxLength = 4;
            txtNoPem.MaxLength = 5;
            txtKdUser.MaxLength = 4;
            dtTanggal.Value = DateTime.Now;
            dtTanggal.Value = DateTime.Now;
            txtKdPaket.Enabled = false;
            txtHargaPaket.Enabled = false;
            txtNoPem.Enabled = false;
            dtTanggal.Enabled = false;
            txtKdUser.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmUtama = new FrmUtama();
            frmUtama.Closed += (s, args) => this.Close();
            frmUtama.Show();
        }

        private void InitializeComboBox()
        {
            if (koneksi.OpenConnection())
            {
                string query = "SELECT kode_travel, nama_travel from tbltravel";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.da = new MySqlDataAdapter();
                koneksi.da.SelectCommand = koneksi.cmd;

                DataTable dt = new DataTable();
                koneksi.da.Fill(dt);
                cmbPaket.DataSource = dt;
                cmbPaket.ValueMember = "kode_travel";
                cmbPaket.DisplayMember = "nama_travel";
                koneksi.CloseConnection();
            }
        }

        private void generateNoPe()
        {
            if (koneksi.OpenConnection())
            {
                string nomor = "";
                string query = "SELECT RIGHT (no_pemesanan, 3)+1 AS no FROM tbpemesanan ORDER BY no DESC LIMIT 1";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                if (koneksi.dr.Read())
                {
                    int x = koneksi.dr.GetInt32(0);
                    if (x <= 9)
                    {
                        nomor = String.Concat("M00", koneksi.dr["no"].ToString());
                    }
                    else if (x <= 99)
                    {
                        nomor = String.Concat("M0", koneksi.dr["no"].ToString());
                    }
                    else if (x <= 999)
                    {
                        nomor = String.Concat("M", koneksi.dr["no"].ToString());
                    }
                    else
                    {
                        nomor = "M001";
                    }
                    txtNoPem.Text = nomor;
                    koneksi.dr.Close();
                    koneksi.CloseConnection();
                }

            }
        }

        private void InitializeKodePelanggan()
        {
            if (koneksi.OpenConnection())
            {
                string query = String.Concat("SELECT kode_pelanggan from tblpelanggan WHERE kode_pelanggan='", txtKdUser.Text, "'");
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();
                if (koneksi.dr.Read())
                {
                    txtKdUser.Text = koneksi.dr["kode_pelanggan"].ToString();
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            generateNoPe();
        }

        private void nmTiket_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nmTiket_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDiBayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaket_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaket.Text.Equals("Palembang - Indralaya", StringComparison.InvariantCultureIgnoreCase))
            {
                txtKdPaket.Text = "T001";
                txtHargaPaket.Text = "40000";
            }
            else if (cmbPaket.Text.Equals("Palembang - Prabumulih", StringComparison.InvariantCultureIgnoreCase))
            {
                txtKdPaket.Text = "T002";
                txtHargaPaket.Text = "60000";
            }
            else if (cmbPaket.Text.Equals("Palembang - Muaraenim", StringComparison.InvariantCultureIgnoreCase))
            {
                txtKdPaket.Text = "T003";
                txtHargaPaket.Text = "75000";
            }
            else if (cmbPaket.Text.Equals("Palembang - Lampung", StringComparison.InvariantCultureIgnoreCase))
            {
                txtKdPaket.Text = "T004";
                txtHargaPaket.Text = "100000";
            }
            else if (cmbPaket.Text.Equals("Palembang - KayuAgung", StringComparison.InvariantCultureIgnoreCase))
            {
                txtKdPaket.Text = "T005";
                txtHargaPaket.Text = "60000";
            }
            else if (cmbPaket.Text.Equals("Palembang - Baturaja", StringComparison.InvariantCultureIgnoreCase))
            {
                txtKdPaket.Text = "T006";
                txtHargaPaket.Text = "60000";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PreviewDataPelanggan previewDataPel = new PreviewDataPelanggan();
            previewDataPel.ShowDialog();

            txtKdUser.Text = previewDataPel.tkode_pel;
            InitializeKodePelanggan();
            btnAddUser.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                if (koneksi.OpenConnection())
                {
                    string query = String.Concat("INSERT INTO tbpemesanan VALUES('", txtNoPem.Text, "','", txtKdUser.Text, "','", txtKdPaket.Text, "','", cmbPaket.Text, "','", txtHargaPaket.Text, "','", dtTanggal.Value.ToString("yyyy-MM-dd"), "','", dtBerangkat.Value.ToString("yyyy-MM-dd"),"','", nmTiket.Text, "')");
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.cmd.ExecuteNonQuery();
                    koneksi.CloseConnection();

                    MessageBox.Show("Pemesanan berhasil");
                    bersih();
                }
        }
    }
}
