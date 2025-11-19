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

namespace Akademik.View
{
    public partial class UpdateData : Form
    {
        AkademikController akademikController;

        private Dictionary<string, List<string>> fakultasProdi = new Dictionary<string, List<string>>
        {
            { "Ekonomi", new List<string> { "S1 Manajemen", "S1 Akuntansi" } },
            { "Teknik", new List<string> { "S1 Teknik Mesin", "S1 Teknik Sipil", "S1 Teknik Industri" } },
            { "Ilmu Komputer", new List<string> { "S1 Teknik Informatika", "D3 Manajemen Informatika" } },
            { "Sastra", new List<string> { "S1 Sastra Jepang", "D3 Sastra Inggris" } },
            { "Psikologi", new List<string> { "Psikologi" } }
        };


        public UpdateData(string nim, string nama, string fakultas, string prodi, string alamat, string nohp)
        {
            akademikController = new AkademikController();
            InitializeComponent();
            this.cbx_fakultas.SelectedIndexChanged += new System.EventHandler(this.cbx_fakultas_SelectedIndexChanged);

            cbx_fakultas.Items.AddRange(fakultasProdi.Keys.ToArray());

            txt_nim.Text = nim;
            txt_nama.Text = nama;

            cbx_fakultas.SelectedItem = fakultas;

            if (fakultasProdi.ContainsKey(fakultas))
            {
                cbx_prodi.Items.Clear();
                cbx_prodi.Items.AddRange(fakultasProdi[fakultas].ToArray());
            }

            cbx_prodi.SelectedItem = prodi;
            txt_alamat.Text = alamat;
            txt_no_hp.Text = nohp;
        }

         private void cbx_fakultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fakultas = cbx_fakultas.SelectedItem.ToString();

            cbx_prodi.Items.Clear();
            cbx_prodi.Items.AddRange(fakultasProdi[fakultas].ToArray());
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            bool sukses = akademikController.UpdateData(
                 txt_nim.Text.Trim(),
                 txt_nama.Text.Trim(),
                 cbx_fakultas.SelectedItem.ToString(),
                 cbx_prodi.SelectedItem.ToString(),
                 txt_alamat.Text.Trim(),
                 txt_no_hp.Text.Trim()
             );

            if (sukses)
            {
                MessageBox.Show("Data berhasil diupdate!");

              
                ShowData show = Application.OpenForms["ShowData"] as ShowData;

                if (show != null)
                {
                    show.RefreshData();
                    show.Show();
                }
                else
                {
                    ShowData baru = new ShowData();
                    this.Close();
                    baru.Show();
                }
                this.Close();
            }
        }

        

        private void UpdateData_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ShowData show = new ShowData();
            show.Show();
            this.Close();
        }

    }
}
