using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoinSiswa_Form.Model;
using PoinSiswa_Form.Automata;

namespace PoinSiswa_Form.Forms
{
    public partial class FormRiwayatPelanggaran : Form
    {
        private DataGridView dgvRiwayat;
        private BindingSource source;

        public FormRiwayatPelanggaran()
        {
            this.Text = "Riwayat Pelanggaran";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.WhiteSmoke;

            dgvRiwayat = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false
            };

            dgvRiwayat.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id" });
            dgvRiwayat.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nama Siswa", DataPropertyName = "NamaSiswa" });
            dgvRiwayat.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kelas", DataPropertyName = "KelasSiswa" });
            dgvRiwayat.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Jenis Pelanggaran", DataPropertyName = "Jenis" });
            dgvRiwayat.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tanggal", DataPropertyName = "Tanggal" });
            dgvRiwayat.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
            dgvRiwayat.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Sanksi", DataPropertyName = "Sanksi" });

            Controls.Add(dgvRiwayat);

            source = new BindingSource();
            source.DataSource = Program.SemuaPelanggaran;
            dgvRiwayat.DataSource = source;

            dgvRiwayat.CellDoubleClick += DgvRiwayat_CellDoubleClick;
        }

        private void DgvRiwayat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pelanggaran = (Pelanggaran)dgvRiwayat.Rows[e.RowIndex].DataBoundItem;
                var statusForm = new FormUbahStatusPelanggaran(pelanggaran);
                statusForm.ShowDialog();
                source.ResetBindings(false);
            }
        }
    }
}
