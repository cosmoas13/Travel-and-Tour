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
    public partial class frmDetailPenjualan : Form
    {
        Connection koneksi = new Connection();
        public frmDetailPenjualan()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void frmDetailPenjualan_Load(object sender, EventArgs e)
        {
            gb1.Left = (this.ClientSize.Width - gb1.Width) / 2;
            gb1.Top = (this.ClientSize.Height - gb1.Height) / 2;

            bersih();
        }


        private void bersih() {
            txtNoPem.Clear();
            txtKodePel.Clear();
            txtKodeTrav.Clear();
            txtNamaTrav.Clear();
            txtHargaTrav.Clear();
            txtTiket.Clear();
            txtBayar.Clear();
            txtDiBayar.Clear();
            txtKembali.Clear();
            cmbStatus.Items.Add("Lunas");
            cmbStatus.Items.Add("Belum Lunas");
            txtNoPem.Enabled=false;
            txtKodePel.Enabled = false;
            txtKodeTrav.Enabled = false;
            txtNamaTrav.Enabled = false;
            txtHargaTrav.Enabled = false;
            txtTiket.Enabled = false;
            txtBayar.Enabled = false;
            txtKembali.Enabled = false;

            tampildata();
        }

        private void InitializeNoPeme()
        {
            if (koneksi.OpenConnection())
            {
                string query = String.Concat("SELECT no_pemesanan from tbpemesanan WHERE no_pemesanan='", txtNoPem.Text, "'");
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();
                if (koneksi.dr.Read())
                {
                    txtNoPem.Text = koneksi.dr["no_pemesanan"].ToString();
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void InitializeComboBox()
        {
            if (koneksi.OpenConnection())
            {
                string query = "SELECT kode_mobil, nama_mobil from tblmobil";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.da = new MySqlDataAdapter();
                koneksi.da.SelectCommand = koneksi.cmd;

                DataTable dt = new DataTable();
                koneksi.da.Fill(dt);
                cmbKend.DataSource = dt;
                cmbKend.ValueMember = "kode_mobil";
                cmbKend.DisplayMember = "nama_mobil";
                koneksi.CloseConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbStatus.Items.Remove(0);
            cmbStatus.Items.Remove(1);
            bersih();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            PreviewDataPemesanan previewDataPem = new PreviewDataPemesanan();
            previewDataPem.ShowDialog();

            txtNoPem.Text = previewDataPem.tno_pem;
            txtKodePel.Text = previewDataPem.tkd_pel;
            txtKodeTrav.Text = previewDataPem.tkd_trav;
            txtNamaTrav.Text = previewDataPem.tnama_trav;
            txtHargaTrav.Text = previewDataPem.tharga_trav;
            txtTiket.Text = previewDataPem.ttiket;

            InitializeNoPeme();
            btnCari.Enabled = true;
        }

        private void txtDiBayar_TextChanged(object sender, EventArgs e)
        {
            if (txtDiBayar.Text == "") { txtDiBayar.Text = ""; }
            else { txtKembali.Text = (Convert.ToInt32(txtDiBayar.Text) - Convert.ToInt32(txtBayar.Text)).ToString(); }
        }

        private void txtTiket_TextChanged(object sender, EventArgs e)
        {
            if (txtTiket.Text == "") { txtTiket.Text = ""; }
            else { txtBayar.Text = (Convert.ToInt32(txtHargaTrav.Text) * Convert.ToInt32(txtTiket.Text)).ToString(); }
        }

        private void tampildata()
        {
            if (koneksi.OpenConnection())
            {
                string query = "SELECT no_pemesanan, kode_pelanggan, kode_travel, nama_travel, harga_travel, jumlah_tiket, total_bayar, bayar, kembalian, status, kendaraan FROM tbdetail";
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();
                Clearlistview();

                ListViewItem listviewitem;
                while (koneksi.dr.Read())
                {
                    listviewitem = new ListViewItem(koneksi.dr["no_pemesanan"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["kode_pelanggan"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["kode_travel"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["nama_travel"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["harga_travel"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["jumlah_tiket"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["total_bayar"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["bayar"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["kembalian"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["status"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["kendaraan"].ToString());
                    lvView.Items.Add(listviewitem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }
        public void Clearlistview()
        {
            lvView.Clear();
            lvView.Columns.Add("no_pemesanan", 40, HorizontalAlignment.Center);
            lvView.Columns.Add("kode_pelanggan", 150, HorizontalAlignment.Left);
            lvView.Columns.Add("kode_travel", 150, HorizontalAlignment.Left);
            lvView.Columns.Add("nama_travel", 100, HorizontalAlignment.Left);
            lvView.Columns.Add("harga_travel", 150, HorizontalAlignment.Left);
            lvView.Columns.Add("jumlah_tiket", 150, HorizontalAlignment.Left);
            lvView.Columns.Add("total_bayar", 150, HorizontalAlignment.Left);
            lvView.Columns.Add("yang_dibayar", 150, HorizontalAlignment.Left);
            lvView.Columns.Add("kembalian", 150, HorizontalAlignment.Left);
            lvView.Columns.Add("status", 150, HorizontalAlignment.Left);
            lvView.Columns.Add("kendaraan", 150, HorizontalAlignment.Left);
            lvView.View = View.Details;
            lvView.GridLines = true;
            lvView.FullRowSelect = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {
                string query = String.Concat("INSERT INTO tbdetail VALUES('", txtNoPem.Text, "','", txtKodePel.Text, "','", txtKodeTrav.Text, "','", txtNamaTrav.Text, "','", txtHargaTrav.Text, "','", txtTiket.Text, "','", txtBayar.Text, "','", txtDiBayar.Text, "','", txtKembali.Text, "','", cmbStatus.Text, "','", cmbKend.Text, "')");
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.cmd.ExecuteNonQuery();
                koneksi.CloseConnection();

                MessageBox.Show("Pembayaran berhasil");
                cmbStatus.Items.Remove(0);
                cmbStatus.Items.Remove(1);
                bersih();
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {

                string query = string.Concat("SELECT * FROM tbdetail WHERE no_pemesanan like '%", txtCari.Text, "%' OR kode_pelanggan LIKE '%", txtCari.Text, "%' OR kode_travel LIKE '%", txtCari.Text, "%' OR nama_travel LIKE '%", txtCari.Text, "%' OR harga_travel LIKE '%", txtCari.Text, "%' OR jumlah_tiket LIKE '%", txtCari.Text, "%' OR total_bayar LIKE '%", txtCari.Text, "%' OR bayar LIKE '%", txtCari.Text, "%' OR kembalian LIKE '%", txtCari.Text, "%' OR status LIKE '%", txtCari.Text, "%' OR kendaraan LIKE '%", txtCari.Text, "%'");

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                Clearlistview();
                ListViewItem listviewitem;
                while (koneksi.dr.Read())
                {
                    listviewitem = new ListViewItem(koneksi.dr["no_pemesanan"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["kode_pelanggan"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["kode_travel"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["nama_travel"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["harga_travel"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["jumlah_tiket"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["total_bayar"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["bayar"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["kembalian"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["status"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["kendaraan"].ToString());
                    lvView.Items.Add(listviewitem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void txtCari_Click(object sender, EventArgs e)
        {
            txtCari.Text = "";
        }

        private void txtCari_Leave(object sender, EventArgs e)
        {
            txtCari.Text = "Masukkan kata kunci pencarian...";
        }
    }
}
