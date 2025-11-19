using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Akademik.Controller;
using MySqlConnector;

namespace Akademik.View
{
    public partial class ShowData : Form
    {
        AkademikController akademikController;
        public ShowData()
        {
            akademikController = new AkademikController();
            InitializeComponent();
        }


        private void ShowData_Load(object sender, EventArgs e)
        {
            showTable();

        }

        bool showTable()
        {
            dgv_data_mhs.DataSource = akademikController.tampilkanDataMhs(new MySqlCommand("SELECT * FROM mahasiswa"));
            dgv_data_mhs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            return true;
        }
        public void RefreshData()
        {
            showTable();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            AddDataMhs addDataMhs = new AddDataMhs();
            addDataMhs.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_data_mhs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            // Ambil nilai dari baris yang dipilih
            string nim = dgv_data_mhs.SelectedRows[0].Cells["nim"].Value.ToString();
            string nama = dgv_data_mhs.SelectedRows[0].Cells["nama_mhs"].Value.ToString();
            string fakultas = dgv_data_mhs.SelectedRows[0].Cells["fakultas"].Value.ToString();
            string prodi = dgv_data_mhs.SelectedRows[0].Cells["prodi"].Value.ToString();
            string alamat = dgv_data_mhs.SelectedRows[0].Cells["alamat"].Value.ToString();
            string nohp = dgv_data_mhs.SelectedRows[0].Cells["no_hp"].Value.ToString();

            // Kirim ke form UpdateData
            UpdateData updateForm = new UpdateData(
                nim, nama, fakultas, prodi, alamat, nohp
            );

            updateForm.Show();
            this.Hide();

        }

        private void dgv_data_mhs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string Delete = this.dgv_data_mhs.CurrentRow.Cells[0].Value.ToString();
            akademikController.DeleteData(Delete);
            showTable();

            MessageBox.Show("Data berhasil dihapus");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
