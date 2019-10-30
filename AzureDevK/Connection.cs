using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace AzureDevK
{
    class Connection
    {
        private string server = "localhost";
        private string database = "dbawkt";
        private string uid = "root";
        private string password = "";
        private string connectionString;
        public MySqlConnection connection;

        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter da;
        public MySqlDataReader dr;
        public DataSet ds;

        public Connection()
        {
            Initialize();
        }

        private void Initialize()
        {
            connectionString = "server=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; convert zero Datetime=" + true + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot Connect to Server. contact to administrator");
                        break;
                    case 1045:
                        MessageBox.Show("invalid username password, please try again");
                        break;
                }
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
