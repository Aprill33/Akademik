namespace Akademik.View
{
    partial class ShowData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowData));
            this.gbx_akademik = new System.Windows.Forms.GroupBox();
            this.imgbx_logo_pasim = new System.Windows.Forms.PictureBox();
            this.lbl_unaspasim = new System.Windows.Forms.Label();
            this.lbl_akademik = new System.Windows.Forms.Label();
            this.dgv_data_mhs = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gbx_akademik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbx_logo_pasim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_mhs)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_akademik
            // 
            this.gbx_akademik.BackColor = System.Drawing.Color.White;
            this.gbx_akademik.Controls.Add(this.imgbx_logo_pasim);
            this.gbx_akademik.Controls.Add(this.lbl_unaspasim);
            this.gbx_akademik.Controls.Add(this.lbl_akademik);
            this.gbx_akademik.Location = new System.Drawing.Point(59, 12);
            this.gbx_akademik.Name = "gbx_akademik";
            this.gbx_akademik.Size = new System.Drawing.Size(1116, 107);
            this.gbx_akademik.TabIndex = 1;
            this.gbx_akademik.TabStop = false;
            // 
            // imgbx_logo_pasim
            // 
            this.imgbx_logo_pasim.Image = ((System.Drawing.Image)(resources.GetObject("imgbx_logo_pasim.Image")));
            this.imgbx_logo_pasim.Location = new System.Drawing.Point(56, 22);
            this.imgbx_logo_pasim.Name = "imgbx_logo_pasim";
            this.imgbx_logo_pasim.Size = new System.Drawing.Size(100, 72);
            this.imgbx_logo_pasim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgbx_logo_pasim.TabIndex = 1;
            this.imgbx_logo_pasim.TabStop = false;
            // 
            // lbl_unaspasim
            // 
            this.lbl_unaspasim.AutoSize = true;
            this.lbl_unaspasim.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unaspasim.ForeColor = System.Drawing.Color.RosyBrown;
            this.lbl_unaspasim.Location = new System.Drawing.Point(408, 62);
            this.lbl_unaspasim.Name = "lbl_unaspasim";
            this.lbl_unaspasim.Size = new System.Drawing.Size(252, 23);
            this.lbl_unaspasim.TabIndex = 2;
            this.lbl_unaspasim.Text = "Universitas Nasional Pasim";
            // 
            // lbl_akademik
            // 
            this.lbl_akademik.AutoSize = true;
            this.lbl_akademik.Font = new System.Drawing.Font("Algerian", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_akademik.ForeColor = System.Drawing.Color.RosyBrown;
            this.lbl_akademik.Location = new System.Drawing.Point(321, 22);
            this.lbl_akademik.Name = "lbl_akademik";
            this.lbl_akademik.Size = new System.Drawing.Size(432, 31);
            this.lbl_akademik.TabIndex = 1;
            this.lbl_akademik.Text = "Sistem Informasi Akademik";
            // 
            // dgv_data_mhs
            // 
            this.dgv_data_mhs.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data_mhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_mhs.GridColor = System.Drawing.Color.RosyBrown;
            this.dgv_data_mhs.Location = new System.Drawing.Point(194, 125);
            this.dgv_data_mhs.MultiSelect = false;
            this.dgv_data_mhs.Name = "dgv_data_mhs";
            this.dgv_data_mhs.RowHeadersWidth = 62;
            this.dgv_data_mhs.RowTemplate.Height = 28;
            this.dgv_data_mhs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data_mhs.Size = new System.Drawing.Size(981, 424);
            this.dgv_data_mhs.TabIndex = 2;
            this.dgv_data_mhs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_mhs_CellContentClick);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_add.Location = new System.Drawing.Point(59, 161);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 69);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_update.Location = new System.Drawing.Point(59, 250);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 69);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_delete.Location = new System.Drawing.Point(59, 337);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 69);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.RosyBrown;
            this.btn_exit.Location = new System.Drawing.Point(59, 487);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(115, 47);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1256, 601);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_data_mhs);
            this.Controls.Add(this.gbx_akademik);
            this.Name = "ShowData";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.ShowData_Load);
            this.gbx_akademik.ResumeLayout(false);
            this.gbx_akademik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgbx_logo_pasim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_mhs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_akademik;
        private System.Windows.Forms.PictureBox imgbx_logo_pasim;
        private System.Windows.Forms.Label lbl_unaspasim;
        private System.Windows.Forms.Label lbl_akademik;
        private System.Windows.Forms.DataGridView dgv_data_mhs;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
    }
}