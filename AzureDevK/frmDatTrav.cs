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
    public partial class frmDatTrav : Form
    {
        Connection koneksi = new Connection();
        public frmDatTrav()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmUtama = new FrmUtama();
            frmUtama.Closed += (s, args) => this.Close();
            frmUtama.Show();
        }

        private void frmDatTrav_Load(object sender, EventArgs e)
        {
            bersih();
        }

        private void bersih()
        {
            txtKdTravel.MaxLength = 4;
            txtKdTravel.Clear();
            txtNama.Clear();
            txtHarga.Clear();
            txtKdTravel.Enabled = false;
            clearListView();
            tampilData();
        }

        private void clearListView()
        {
            lvView.Clear();
            lvView.Columns.Add("Kode Travel", 270, HorizontalAlignment.Center);
            lvView.Columns.Add("Nama Travel", 435, HorizontalAlignment.Center);
            lvView.Columns.Add("Harga Travel", 270, HorizontalAlignment.Center);
          
            lvView.View = View.Details;
            lvView.GridLines = true;
            lvView.FullRowSelect = true;

        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tampilData()
        {
            if (koneksi.OpenConnection())
            {
                string query = "Select * from tbltravel";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();
                clearListView();


                ListViewItem listViewItem;
                while (koneksi.dr.Read())
                {
                    listViewItem = new ListViewItem(koneksi.dr["kode_travel"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["nama_travel"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["harga"].ToString());
                    lvView.Items.Add(listViewItem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (btnSimpan.Text.Equals("&Simpan"))
            {
                if (koneksi.OpenConnection())
                {
                    string query = String.Concat("INSERT INTO tblTravel VALUES('", txtKdTravel.Text, "','",txtNama.Text, "','",
                        txtHarga.Text, "')");
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
                    string query = String.Concat("UPDATE tbltravel SET nama_travel ='", txtNama.Text,
                    "', harga ='", txtHarga.Text, "' WHERE kode_travel ='",
                    txtKdTravel.Text, "'");
                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.cmd.ExecuteNonQuery();
                    koneksi.CloseConnection();
                    MessageBox.Show("Update Data Success");
                    bersih();
                }
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {
                String query = String.Concat("SELECT * FROM tbltravel Where kode_travel LIKE '%",
                    txtCari.Text, "%' OR kode_travel LIKE '%",
                    txtCari.Text, "%' OR nama_travel LIKE '%",
                    txtCari.Text, "%' OR harga LIKE '%",
                    txtCari.Text, "%'");

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                clearListView();
                ListViewItem listViewItem;

                while (koneksi.dr.Read())
                {
                    listViewItem = new ListViewItem(koneksi.dr["kode_travel"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["nama_travel"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["harga"].ToString());
               
                    lvView.Items.Add(listViewItem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void txtCari_Leave(object sender, EventArgs e)
        {
            if (txtCari.Text.Trim().Length == 0)
            {
                txtCari.Text = "Masukkan Kata Kunci Pencarian.....";
                tampilData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             if (koneksi.OpenConnection())
            {
                string nomor = "";
                string query = "SELECT RIGHT (kode_travel, 3)+1 AS kode_travel FROM tbltravel ORDER BY kode_travel DESC LIMIT 1";

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                if (koneksi.dr.Read())
                {
                    int x = koneksi.dr.GetInt32(0);
                    if (x <= 9)
                    {
                        nomor = String.Concat("T00", koneksi.dr["kode_travel"].ToString());
                    }
                    else if (x <= 99)
                    {
                        nomor = String.Concat("T0", koneksi.dr["kode_travel"].ToString());
                    }
                    else if (x <= 999)
                    {
                        nomor = String.Concat("T", koneksi.dr["kode_travel"].ToString());
                    }
                    else
                    {
                        nomor = "T001";
                    }
                    btnSimpan.Enabled = true;
                    btnSimpan.Text = "&Simpan";
                    txtNama.Clear();
                    txtHarga.Clear();
                    txtKdTravel.Text = nomor;
                    txtNama.Focus();
                    koneksi.dr.Close();
                    koneksi.CloseConnection();
                }
            }
        }

        private void txtCari_Click(object sender, EventArgs e)
        {
            txtCari.Clear();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void lvView_DoubleClick(object sender, EventArgs e)
        {
             if (lvView.Items.Count > 0)
            {
                ListViewItem itemRow = lvView.Items[lvView.FocusedItem.Index];
                txtKdTravel.Text= itemRow.SubItems[0].Text;
                txtNama.Text = itemRow.SubItems[1].Text;
                txtHarga.Text = itemRow.SubItems[2].Text;
            }
            btnSimpan.Text = "&Update";
            btnSimpan.Enabled = true;
        }
    }
 }
    

