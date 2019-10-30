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
    public partial class PreviewDataPemesanan : Form
    {
        Connection koneksi = new Connection();

        private string no_pem;

        public string tno_pem
        {
            get { return no_pem; }
            set { no_pem = value; }
        }

        private string kd_pel;

        public string tkd_pel
        {
            get { return kd_pel; }
            set { kd_pel = value; }
        }

        private string kd_trav;

        public string tkd_trav
        {
            get { return kd_trav; }
            set { kd_trav = value; }
        }

        private string nama_trav;

        public string tnama_trav
        {
            get { return nama_trav; }
            set { nama_trav = value; }
        }


        private string harga_trav;

        public string tharga_trav
        {
            get { return harga_trav; }
            set { harga_trav = value; }
        }

        private string tiket;

        public string ttiket
        {
            get { return tiket; }
            set { tiket = value; }
        }


        public PreviewDataPemesanan()
        {
            InitializeComponent();
        }

        private void PreviewDataPemesanan_Load(object sender, EventArgs e)
        {
            tampildata();
        }

        public void Clearlistview()
        {
            lvpreviewpelanggan.Clear();
            lvpreviewpelanggan.Columns.Add("no_pemesanan", 40, HorizontalAlignment.Center);
            lvpreviewpelanggan.Columns.Add("kode_pelanggan", 150, HorizontalAlignment.Left);
            lvpreviewpelanggan.Columns.Add("kode_travel", 150, HorizontalAlignment.Left);
            lvpreviewpelanggan.Columns.Add("nama_travel", 100, HorizontalAlignment.Left);
            lvpreviewpelanggan.Columns.Add("harga_travel", 150, HorizontalAlignment.Left);
            lvpreviewpelanggan.Columns.Add("tanggal_pesan", 150, HorizontalAlignment.Left);
            lvpreviewpelanggan.Columns.Add("tanggal_berangkat", 150, HorizontalAlignment.Left);
            lvpreviewpelanggan.Columns.Add("jumlah_tiket", 100, HorizontalAlignment.Left);
            lvpreviewpelanggan.View = View.Details;
            lvpreviewpelanggan.GridLines = true;
            lvpreviewpelanggan.FullRowSelect = true;
        }

        private void tampildata()
        {
            if (koneksi.OpenConnection())
            {
                string query = "SELECT no_pemesanan, kode_pelanggan, kode_travel, nama_travel, harga_travel, tanggal_pesan, tanggal_berangkat, jumlah_tiket FROM tbpemesanan";
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
                    listviewitem.SubItems.Add(koneksi.dr["tanggal_pesan"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["tanggal_berangkat"].ToString());
                    listviewitem.SubItems.Add(koneksi.dr["jumlah_tiket"].ToString());
                    lvpreviewpelanggan.Items.Add(listviewitem);
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
                tno_pem = itemRow.SubItems[0].Text;
                tkd_pel = itemRow.SubItems[1].Text;
                tkd_trav = itemRow.SubItems[2].Text;
                tnama_trav = itemRow.SubItems[3].Text;
                tharga_trav = itemRow.SubItems[4].Text;
                ttiket = itemRow.SubItems[7].Text;
            }
            this.Close();
        }

        private void txtcaribar_TextChanged(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {

                string query = string.Concat("SELECT * FROM tbpemesanana WHERE no_pemesanan like '%", txtcaribar.Text, "%' OR kode_pelanggan LIKE '%", txtcaribar.Text, "%' OR kode_travel LIKE '%", txtcaribar.Text, "%' OR nama_travel LIKE '%", txtcaribar.Text, "%' OR harga_travel LIKE '%", txtcaribar.Text, "%' OR tanggal_pesan LIKE '%", txtcaribar.Text, "%' OR tanggal_berangkat LIKE '%", txtcaribar.Text, "%' OR jumlah_tiket LIKE '%", txtcaribar.Text, "%'");

                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();

                Clearlistview();
                ListViewItem listViewItem;

                while (koneksi.dr.Read())
                {
                    listViewItem = new ListViewItem(koneksi.dr["no_pemesanan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["kode_pelanggan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["kode_travel"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["nama_travel"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["harga_travel"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["tanggal_pesan"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["tanggal_berangkat"].ToString());
                    listViewItem.SubItems.Add(koneksi.dr["jumlah_tiket"].ToString());
                    lvpreviewpelanggan.Items.Add(listViewItem);
                }
                koneksi.dr.Close();
                koneksi.CloseConnection();
            }
        }
    }
}
