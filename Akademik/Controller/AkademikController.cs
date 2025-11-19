using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace Akademik.Controller
{
    internal class AkademikController : Model.Connection
    {
        public DataTable tampilkanDataMhs(MySqlCommand cmd)
{
    DataTable data = new DataTable();
    try
    {
        using (MySqlConnection conn = GetConn())
        {
            cmd.Connection = conn;
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                da.Fill(data);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
    return data;
}


        public bool AddDataMhs(string Nim, string Nama, string Fakultas, string Prodi, string Alamat, string Nohp)
        {
            string addData = "INSERT INTO mahasiswa (nim, nama_mhs, fakultas, prodi, alamat, no_hp) VALUES (@Nim, @Nama, @Fakultas, @Prodi, @Alamat, @Nohp)";

            try
            {
                cmd = new MySqlCommand(addData, GetConn());

                cmd.Parameters.Add("@Nim", MySqlDbType.VarChar).Value = Nim;        
                cmd.Parameters.Add("@Nama", MySqlDbType.VarChar).Value = Nama;
                cmd.Parameters.Add("@Fakultas", MySqlDbType.VarChar).Value = Fakultas;
                cmd.Parameters.Add("@Prodi", MySqlDbType.VarChar).Value = Prodi;    
                cmd.Parameters.Add("@Alamat", MySqlDbType.VarChar).Value = Alamat;
                cmd.Parameters.Add("@Nohp", MySqlDbType.VarChar).Value = Nohp;      

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("NIM sudah ada! Gunakan NIM lain.", "Duplikat NIM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Gagal simpan: " + ex.Message + "\nError Code: " + ex.Number);
                return false;
            }
        }
        public bool UpdateData(string Nim, string Nama, string Fakultas, string Prodi, string Alamat, string Nohp)
        {
            string query = "UPDATE mahasiswa SET nama_mhs=@Nama, fakultas=@Fakultas, prodi=@Prodi, alamat=@Alamat, no_hp=@Nohp WHERE nim=@Nim";

            try
            {
                using (MySqlConnection conn = GetConn())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.Add("@Nama", MySqlDbType.VarChar).Value = Nama;
                    cmd.Parameters.Add("@Fakultas", MySqlDbType.VarChar).Value = Fakultas;
                    cmd.Parameters.Add("@Prodi", MySqlDbType.VarChar).Value = Prodi;
                    cmd.Parameters.Add("@Alamat", MySqlDbType.VarChar).Value = Alamat;
                    cmd.Parameters.Add("@Nohp", MySqlDbType.VarChar).Value = Nohp;
                    cmd.Parameters.Add("@Nim", MySqlDbType.VarChar).Value = Nim;

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Update: " + ex.Message);
                return false;
            }
        }

        public void DeleteData(string nim)
        {
            string delete = "DELETE FROM mahasiswa WHERE nim=@nim";

            try
            {
                using (MySqlConnection conn = GetConn())
                {
                    MySqlCommand cmd = new MySqlCommand(delete, conn);
                    cmd.Parameters.Add("@nim", MySqlDbType.VarChar).Value = nim;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Gagal: " + ex.Message);
            }
        }


    }
}
