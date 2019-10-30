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
    public partial class FrmLogin : Form
    {
        Connection koneksi = new Connection();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (koneksi.OpenConnection())
            {
                string query = String.Concat("SELECT * FROM tbladmin WHERE kode_admin='", txtKduser.Text, "' AND password='", txtPw.Text, "'");
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dr = koneksi.cmd.ExecuteReader();
                

                if (koneksi.dr.Read())
                {
                    string x = koneksi.dr["nama_admin"].ToString();
                    MessageBox.Show(("Selamat Datang Admin "+x), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    var frmUtama = new FrmUtama();
                    frmUtama.Closed += (s, args) => this.Close();
                    frmUtama.Show();
                }
                else
                {
                    MessageBox.Show("Username dan Password tidak cocok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKduser.Clear();
                    txtPw.Clear();
                    txtKduser.Focus();
                }
                koneksi.CloseConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            isi.Left = (this.ClientSize.Width - isi.Width) / 2;
            isi.Top = (this.ClientSize.Height - isi.Height) / 2;
        }


        private const int WM_NCLBUTTONDBLCLK = 0x00A3; 

        private IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {

            switch (msg)
            {
                case WM_NCLBUTTONDBLCLK:
                    handled = true;
                    break;
                default:
                    break;
            }
            return IntPtr.Zero;
        }

        private void txtKduser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPw.Focus();
            }
        }

        private void txtPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (koneksi.OpenConnection())
                {
                    string query = String.Concat("SELECT * FROM tbladmin WHERE kode_admin='", txtKduser.Text, "' AND password='", txtPw.Text, "'");
                    koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                    koneksi.dr = koneksi.cmd.ExecuteReader();


                    if (koneksi.dr.Read())
                    {
                        string x = koneksi.dr["nama_admin"].ToString();
                        MessageBox.Show(("Selamat Datang Admin " + x), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        var frmUtama = new FrmUtama();
                        frmUtama.Closed += (s, args) => this.Close();
                        frmUtama.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username dan Password tidak cocok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKduser.Clear();
                        txtPw.Clear();
                        txtKduser.Focus();
                    }
                    koneksi.CloseConnection();
                }
            }
        }
    }

}
