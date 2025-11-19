using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace Akademik.Model
{
    internal class Connection
    {

        public MySqlCommand cmd;//untuk menjalankan perintah sql
        public DataSet ds; //wadah untuk menyimpan data
        public MySqlDataAdapter da; //penghubung antara databse dengan data table nya

        public MySqlConnection GetConn()//untuk membuat koneksi ke databse
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=akademik";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filed Connection" + ex.Message);
            }
            return conn;
        }
    }
}
