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
    public partial class FormPelanggan : Form
    {
        Connection koneksi = new Connection();
        string jk;
        public FormPelanggan()
        {
            InitializeComponent();
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            bersih();
            
        }

        private void bersih()
        {
            txtKdUser.MaxLength = 4;
            txtKdUser.Clear();
            txtNama.Clear();
            dtTanggal.Value = DateTime.Now;
            txtEmail.Clear();
            txtNoTelp.Clear();
            txtKdUser.Enabled = false;
            btnSimpan.Text = "&Simpan";
            btnSimpan.Enabled = false;
            clearListView();
            tampilData();
        }



        private void clearListView()
        {
            lvPelanggan.Clear();
            lvPelanggan.Columns.Add("Kode Pelanggan", 120, HorizontalAlignment.Center);
            lvPelanggan.Columns.Add("Nama Pelanggan", 260, HorizontalAlignment.Center);
            lvPelanggan.Columns.Add("Jk", 120, HorizontalAlignment.Center);
            lvPelanggan.Columns.Add("Tanggal Lahir", 180, HorizontalAlignment.Center);
            lvPelanggan.Columns.Add("Email", 260, HorizontalAlignment.Center);
            lvPelanggan.Columns.Add("No telpon", 170, HorizontalAlignment.Center);

            lvPelanggan.View = View.Details;
            lvPelanggan.GridLines = true;
            lvPelanggan.FullRowSelect = true;

        }

        private void txtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (btnSimpan.Text.Equals("&Simpan"))
            {
                if (koneksi.OpenConnection())
                {
                    string query = String.Concat("INSERT INTO tblPelanggan VALUES('", txtKdUser.Text, "','", txtNama.Text, "','",
                        jk, "','", dtTanggal.Value.ToString("yyyy-MM-dd"), "','", txtEmail.Text, "','", txtNoTelp.Text, "')");
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
                    string query = String.Concat("UPDATE tblpelanggan SET nama_pelanggan ='", txtNama.Text,
                    "', jenis_kelamin ='", jk, "', tanggal_lahir ='", dtTanggal.Value.ToString("yyyy-MM-dd"), "',email ='", txtEmail.Text, "', telpon='", txtNoTelp.Text, "' WHERE kode_pelanggan ='",
                    txtKdUser.Text, "'");
                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.cmd.ExecuteNonQuery();
                    koneksi.CloseConnection();
                    MessageBox.Show("Update Data Success");
                    bersih();
                }
            }
        }

        private void rdLaki_CheckedChanged(object sender, EventArgs e)
        {
            jk = "L";
        }

        private void rdPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            jk = "P";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {
                string nomor = "";
                string query = "SELECT RIGHT (kode_pelanggan, 3)+1 AS kode_pelanggan FROM tblpelanggan ORDER BY kode_pelanggan DESC LIMIT 1";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                if (koneksi.dr.Read())
                {
                    int x = koneksi.dr.GetInt32(0);
                    if (x <= 9)
                    {
                        nomor = String.Concat("P00", koneksi.dr["kode_pelanggan"].ToString());
                    }
                    else if (x <= 99)
                    {
                        nomor = String.Concat("P0", koneksi.dr["kode_pelanggan"].ToString());
                    }
                    else if (x <= 999)
                    {
                        nomor = String.Concat("P", koneksi.dr["kode_pelanggan"].ToString());
                    }
                    else
                    {
                        nomor = "P001";
                    }
                    btnSimpan.Enabled = true;
                    txtNama.Clear();
                    rdLaki.Checked = false;
                    rdPerempuan.Checked = false;
                    txtEmail.Clear();
                    txtNoTelp.Clear();
                    dtTanggal.Value = DateTime.Now;
                    btnSimpan.Text = "&Simpan";
                    txtKdUser.Text = nomor;
                    txtNama.Focus();
                    koneksi.dr.Close();
                    koneksi.CloseConnection();
                }
            }
        }

        private void tampilData()
        {
            if (koneksi.OpenConnection())
            {
                string query = "Select * from tblpelanggan";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();
                clearListView();


                ListViewItem listViewItem;
                while (koneksi.dr.Read())
                {
                    listViewItem = new ListViewItem(koneksi.dr["kode_pelanggan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["nama_pelanggan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["jenis_kelamin"].ToString());
                    listViewItem.SubItems.Add(DateTime.Parse(koneksi.dr["tanggal_lahir"].ToString()).ToString("yyyy-MM-dd"));
                    listViewItem.SubItems.Add(koneksi.dr["email"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["telpon"].ToString());
                    lvPelanggan.Items.Add(listViewItem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }


        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {
                String query = String.Concat("SELECT * FROM tblpelanggan Where kode_pelanggan LIKE '%",
                    txtCari.Text, "%' OR kode_pelanggan LIKE '%",
                    txtCari.Text, "%' OR nama_pelanggan LIKE '%",
                    txtCari.Text, "%' OR jenis_kelamin LIKE '%",
                    txtCari.Text, "%' OR tanggal_lahir LIKE '%",
                    txtCari.Text, "%' OR email LIKE '%",
                    txtCari.Text, "%' OR telpon LIKE '%",
                    txtCari.Text, "%'");

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                clearListView();
                ListViewItem listViewItem;

                while (koneksi.dr.Read())
                {
                    listViewItem = new ListViewItem(koneksi.dr["kode_pelanggan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["nama_pelanggan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["jenis_kelamin"].ToString());
                    listViewItem.SubItems.Add(DateTime.Parse(koneksi.dr["tanggal_lahir"].ToString()).ToString("yyyy-MM-dd"));
                    listViewItem.SubItems.Add(koneksi.dr["email"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["telpon"].ToString());
                    lvPelanggan.Items.Add(listViewItem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }



        private void txtCari_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
        }

        private void txtCari_Leave(object sender, EventArgs e)
        {
            if (txtCari.Text.Trim().Length == 0)
            {
                txtCari.Text = "Masukkan Kata Kunci Pencarian.....";
                tampilData();
            }
        }

        private void lvPelanggan_DoubleClick(object sender, EventArgs e)
        {
            if (lvPelanggan.Items.Count > 0)
            {
                ListViewItem itemRow = lvPelanggan.Items[lvPelanggan.FocusedItem.Index];
                txtKdUser.Text = itemRow.SubItems[0].Text;
                txtNama.Text = itemRow.SubItems[1].Text;
                jk = itemRow.SubItems[2].Text;
                if (jk == "L")
                {
                    rdLaki.Checked = true;
                }
                else {
                    rdPerempuan.Checked = true;
                }
                dtTanggal.Value = DateTime.Parse(itemRow.SubItems[3].Text);
                txtEmail.Text = itemRow.SubItems[4].Text;
                txtNoTelp.Text = itemRow.SubItems[5].Text;
            }
            btnSimpan.Text = "&Update";
            btnSimpan.Enabled = true;
        }
    }
}
