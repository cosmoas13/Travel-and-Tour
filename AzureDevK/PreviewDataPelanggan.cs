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
    public partial class PreviewDataPelanggan : Form
    {
        Connection koneksi = new Connection();
        private string kode_pel;

        public string tkode_pel
        {
            get { return kode_pel; }
            set { kode_pel = value; }
        }
        public PreviewDataPelanggan()
        {
            InitializeComponent();
        }
 

        private void PreviewDataPelanggan_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        public void Clearlistview()
        {
            lvpreviewpelanggan.Clear();
           lvpreviewpelanggan.Columns.Add("kode_pelanggan", 40, HorizontalAlignment.Center);
           lvpreviewpelanggan.Columns.Add("Nama", 150, HorizontalAlignment.Left);
           lvpreviewpelanggan.Columns.Add("Jenis Kelamin", 150, HorizontalAlignment.Left);
           lvpreviewpelanggan.Columns.Add("Tanggal Lahir", 100, HorizontalAlignment.Left);
           lvpreviewpelanggan.Columns.Add("email", 150, HorizontalAlignment.Left);
           lvpreviewpelanggan.Columns.Add("Telepon", 150, HorizontalAlignment.Left);
           lvpreviewpelanggan.View = View.Details;
           lvpreviewpelanggan.GridLines = true;
           lvpreviewpelanggan.FullRowSelect = true;
        }

        private void tampildata()
        {
            if (koneksi.OpenConnection())
            {
                string query = "SELECT kode_pelanggan, nama_pelanggan, jenis_kelamin, tanggal_lahir, email, telpon FROM tblpelanggan";
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();
                Clearlistview();

                ListViewItem listviewitem;
                while (koneksi.dr.Read())
                {
                    listviewitem = new ListViewItem(koneksi.dr["kode_pelanggan"].ToString());   
                    listviewitem.SubItems.Add(koneksi.dr["nama_pelanggan"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["jenis_kelamin"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["tanggal_lahir"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["email"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["telpon"].ToString());
                   lvpreviewpelanggan.Items.Add(listviewitem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void txtcaribar_TextChanged(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {

                string query = string.Concat("SELECT * FROM tblpelanggan WHERE kode_pelanggan like '%", txtcaribar.Text, "%' OR nama_pelanggan LIKE '%", txtcaribar.Text, "%' OR jenis-kelamin LIKE '%", txtcaribar.Text, "%' OR tanggal_lahir LIKE '%", txtcaribar.Text, "%' OR email LIKE '%", txtcaribar.Text, "%' OR telpon LIKE '%", txtcaribar.Text,"%'");

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                Clearlistview();
                ListViewItem listViewItem;

                while (koneksi.dr.Read())
                {
                    listViewItem = new ListViewItem(koneksi.dr["kode_pelanggan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["nama_pelanggan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["jenis_kelamin"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["tanggal_lahir"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["email"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["telpon"].ToString());
                   lvpreviewpelanggan.Items.Add(listViewItem);

                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }

        private void lvpreviewpelanggan_DoubleClick(object sender, EventArgs e)
        {
            if (lvpreviewpelanggan.Items.Count > 0)
            {
                ListViewItem itemRow = lvpreviewpelanggan.Items[lvpreviewpelanggan.FocusedItem.Index];
                tkode_pel = itemRow.SubItems[0].Text;
            }
            this.Close();
        }
    }
}
