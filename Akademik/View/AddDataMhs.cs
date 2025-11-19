using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Akademik.Controller;
using Akademik.View;

namespace Akademik
{
    public partial class AddDataMhs : Form
    {
        AkademikController akademikController = new AkademikController();

        private Dictionary<string, List<string>> fakultasProdi = new Dictionary<string, List<string>>
        {
            { "Ekonomi", new List<string> { "S1 Manajemen", "S1 Akuntansi" } },
            { "Teknik", new List<string> { "S1 Teknik Mesin", "S1 Teknik Sipil", "S1 Teknik Industri" } },
            { "Ilmu Komputer", new List<string> { "S1 Teknik Informatika", "D3 Manajemen Informatika" } },
            { "Sastra", new List<string> { "S1 Sastra Jepang", "D3 Sastra Inggris" } },
            { "Psikologi", new List<string> { "Psikologi" } }
        };

        public AddDataMhs()
        {
            InitializeComponent();
            cbx_fakultas.SelectedIndexChanged += cbx_fakultas_SelectedIndexChanged;
            
            btn_back.Click += btn_back_Click;
            this.Load += AddDataMhs_Load;
        }

        private void AddDataMhs_Load(object sender, EventArgs e)
        {
           
            cbx_fakultas.Items.Clear();
            cbx_fakultas.Items.AddRange(new string[] { "Ekonomi", "Teknik", "Ilmu Komputer", "Sastra", "Psikologi" });
            cbx_fakultas.SelectedIndex = 0;
        }

        private void cbx_fakultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_fakultas.SelectedItem == null) return;
            string fak = cbx_fakultas.SelectedItem.ToString();
            cbx_prodi.Items.Clear();
            if (fakultasProdi.ContainsKey(fak))
                cbx_prodi.Items.AddRange(fakultasProdi[fak].ToArray());
            if (cbx_prodi.Items.Count > 0)
                cbx_prodi.SelectedIndex = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool sukses = akademikController.AddDataMhs(
                txt_nim.Text.Trim(),
                txt_nama.Text.Trim(),
                cbx_fakultas.SelectedItem.ToString(),
                cbx_prodi.SelectedItem.ToString(),
                txt_alamat.Text.Trim(),
                txt_no_hp.Text.Trim()
            );

            if (!sukses)
            {
               
                return;
            }

            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ShowData mainForm = Application.OpenForms["ShowData"] as ShowData;

            if (mainForm != null)
            {
                mainForm.RefreshData();
                mainForm.Show();
            }

            this.Close();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            ShowData show = new ShowData();
            show.Show();
            this.Close();
        }
    }
}