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
    public partial class frmDatKend : Form
    {
        Connection koneksi = new Connection();

        public frmDatKend()
        {
            InitializeComponent();

        }

        private void frmDatKend_Load(object sender, EventArgs e)
        {
            gb1.Left = (this.ClientSize.Width - gb1.Width) / 2;
            gb1.Top = (this.ClientSize.Height - gb1.Height) / 2;
            bersih();
            tampilData();
        }

        private void clearListView()
        {
            lvView.Clear();
            lvView.Columns.Add("ID Mobil", 250, HorizontalAlignment.Center);
            lvView.Columns.Add("Nama", 350, HorizontalAlignment.Center);
            lvView.Columns.Add("Tipe", 250, HorizontalAlignment.Center);
            lvView.Columns.Add("Tahun Keluaran", 250, HorizontalAlignment.Center);

            lvView.View = View.Details;
            lvView.GridLines = true;
            lvView.FullRowSelect = true;
        }

        private void generateKode()
        {
            if (koneksi.OpenConnection())
            {
                string KdMobil = "";
                string query = "SELECT RIGHT(kode_mobil,3) +1 as kode FROM tblmobil ORDER BY kode DESC LIMIT 1";
                // Select Kode Pilih 3 terkanan dan diurutkan Secara Desc (Atas ke Bawah) by 1 Teratas 
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                if (koneksi.dr.Read())
                {
                    int x = koneksi.dr.GetInt32(0);// 0= Field Kode, 1 = nama, 2 = jenis, 3 = stok
                    if (x <= 9)
                    {
                        KdMobil = String.Concat("C00", koneksi.dr["kode"].ToString());
                    }
                    else if (x <= 99)
                    {
                        KdMobil = String.Concat("C0", koneksi.dr["kode"].ToString());
                    }
                    else if (x <= 999)
                    {
                        KdMobil = String.Concat("C", koneksi.dr["kode"].ToString());
                    }
                }

                else
                {
                    KdMobil = "C001";
                }
                btnSimpan.Enabled = true;
                txtNamaMobil.Clear();
                txtTipeMobil.Clear();
                dtTanggal.Value = DateTime.Now;
                btnSimpan.Text = "&Simpan";
                txtIdMobil.Text = KdMobil;
                txtNamaMobil.Focus();
                koneksi.dr.Close();
                koneksi.CloseConnection();


            }
        }

        private void tampilData()
        {
            if (koneksi.OpenConnection())
            {
                string query = "Select * from tblmobil";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();
                clearListView();


                ListViewItem listViewItem;
                while (koneksi.dr.Read())
                {
                    listViewItem = new ListViewItem(koneksi.dr["kode_mobil"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["nama_mobil"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["tipe_mobil"].ToString());
                    listViewItem.SubItems.Add(DateTime.Parse(koneksi.dr["tahun_keluaran"].ToString()).ToString("yyyy-MM-dd"));
                   

                    lvView.Items.Add(listViewItem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmUtama = new FrmUtama();
            frmUtama.Closed += (s, args) => this.Close();
            frmUtama.Show();
        }

        private void bersih()
        {
            clearListView();
            tampilData();
            txtIdMobil.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bersih();
            generateKode();
            txtNamaMobil.Focus();
            btnSimpan.Text = "&SIMPAN";
        }

        private void txtCari_Leave(object sender, EventArgs e)
        {
            if (txtCari.Text.Trim().Length == 0)
            {
                txtCari.Text = "Masukkan Kata Kunci Pencarian.....";
                tampilData();
            }
        }

        private void lvView_DoubleClick(object sender, EventArgs e)
        {
            if (lvView.Items.Count > 0)
            {
                ListViewItem itemRow = lvView.Items[lvView.FocusedItem.Index];
                txtIdMobil.Text = itemRow.SubItems[0].Text;
                txtNamaMobil.Text = itemRow.SubItems[1].Text;
                txtTipeMobil.Text = itemRow.SubItems[2].Text;
                string tanggal = dtTanggal.Value.Date.ToString("yyyy-MM-dd");
                tanggal = itemRow.SubItems[3].Text;

            }
            btnSimpan.Text = "&Update";
            btnSimpan.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (btnSimpan.Text.Equals("&Simpan"))
            {
                if (koneksi.OpenConnection())
                {
                    string query = String.Concat("INSERT INTO tblmobil VALUES('", txtIdMobil.Text, "','", txtNamaMobil.Text, "','",
                        txtTipeMobil.Text, "','", "", "','", dtTanggal.Value.ToString("yyyy-MM-dd"), "')");
                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.cmd.ExecuteNonQuery();
                    koneksi.CloseConnection();

                    MessageBox.Show("Insert Data Succes");
                    bersih();

                }
            }
            else
            {
                if (koneksi.OpenConnection())
                {
                    string query = String.Concat("UPDATE tblmobil SET nama_mobil ='", txtNamaMobil.Text,
                    "', tipe_mobil ='", txtTipeMobil.Text, "', tahun_keluaran ='", dtTanggal.Value.ToString("yyyy-MM-dd"),
                    "' WHERE kode_mobil ='", txtIdMobil.Text, "'");
                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.cmd.ExecuteNonQuery();
                    koneksi.CloseConnection();
                    MessageBox.Show("Update Data Success");
                    bersih();
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            bersih();
            generateKode();
            txtNamaMobil.Focus();
            btnSimpan.Text = "&Simpan";
        }

        private void txtCari_TextChanged_1(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {
                String query = String.Concat("SELECT * FROM tblmobil Where kode_mobil LIKE '%",
                    txtCari.Text, "%' OR nama_mobil LIKE '%",
                    txtCari.Text, "%' OR tipe_mobil LIKE '%",
                    txtCari.Text, "%' OR kapasitas_penumpang LIKE '%",
                    txtCari.Text, "%' OR tahun_keluaran LIKE '%",
                    txtCari.Text, "%'");

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                clearListView();
                ListViewItem listViewItem;

                while (koneksi.dr.Read())
                {
                    listViewItem = new ListViewItem(koneksi.dr["kode_mobil"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["nama_mobil"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["tipe_mobil"].ToString());
                    //listViewItem.SubItems.Add(koneksi.dr["kapasitas_penumpang"].ToString());
                    listViewItem.SubItems.Add(DateTime.Parse(koneksi.dr["tahun_keluaran"].ToString()).ToString("yyyy-MM-dd"));
           
                    lvView.Items.Add(listViewItem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void txtCari_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
        }
    }
}

