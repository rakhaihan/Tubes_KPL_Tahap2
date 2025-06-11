using PoinSiswa_Form.Automata;
using PoinSiswa_Form.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoinSiswa_Form.Forms
{
    public partial class FormSiswa : Form
    {
        private BindingSource siswaBindingSource = new();
        private BindingSource pelanggaranBindingSource = new();
        private DataGridView dgvPelanggaran;
        private Button btnAutomata;

        public FormSiswa()
        {

            InitializeComponent();
            this.Load += FormSiswa_Load;
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            var form = new FormBeranda();
            form.Show();
            this.Hide();
        }

        private void btnSiswa_Click(object sender, EventArgs e)
        {

        }

        private void btnPeraturan_Click(object sender, EventArgs e)
        {
            var form = new FormPeraturan();
            form.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            var form = new FormLaporan();
            form.Show();
            this.Hide();
        }

        private void btnDataPelanggaran_Click(object sender, EventArgs e)
        {
            var form = new FormCariDataPelanggaran();
            form.Show();
            this.Hide();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            // === Konfigurasi DataGridView Siswa ===
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "NIS", DataPropertyName = "Id" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nama", DataPropertyName = "Nama" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Kelas", DataPropertyName = "Kelas" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Total Poin", DataPropertyName = "TotalPoin" });

            siswaBindingSource.DataSource = Program.DaftarSiswa;
            dataGridView1.DataSource = siswaBindingSource;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.ClearSelection();

            // === Tambahkan DataGridView untuk Pelanggaran ===
            dgvPelanggaran = new DataGridView
            {
                Location = new Point(dataGridView1.Left, dataGridView1.Bottom + 10),
                Width = dataGridView1.Width,
                Height = 200,
                AutoGenerateColumns = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            dgvPelanggaran.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Jenis", DataPropertyName = "Jenis" });
            dgvPelanggaran.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tanggal", DataPropertyName = "Tanggal" });
            dgvPelanggaran.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status" });
            dgvPelanggaran.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Poin", DataPropertyName = "Poin" });

            pelanggaranBindingSource.DataSource = new List<Pelanggaran>();
            dgvPelanggaran.DataSource = pelanggaranBindingSource;
            Controls.Add(dgvPelanggaran);

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            // === Tombol Automata ===
            btnAutomata = new Button
            {
                Text = "Ubah Status (Automata)",
                Location = new Point(dgvPelanggaran.Left, dgvPelanggaran.Bottom + 10),
                Size = new Size(200, 40),
                BackColor = Color.LightGreen
            };
            btnAutomata.Click += BtnAutomata_Click;
            Controls.Add(btnAutomata);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var siswa = (Siswa)dataGridView1.SelectedRows[0].DataBoundItem;
            pelanggaranBindingSource.DataSource = siswa.RiwayatPelanggaran;
            pelanggaranBindingSource.ResetBindings(false);
        }

        private void BtnAutomata_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dgvPelanggaran.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih siswa dan salah satu pelanggaran.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var siswa = (Siswa)dataGridView1.SelectedRows[0].DataBoundItem;
            var pelanggaran = (Pelanggaran)dgvPelanggaran.SelectedRows[0].DataBoundItem;

            var fsm = new PelanggaranStateMachine();
            try
            {
                fsm.ActivateTo(GetNextStatus(pelanggaran.Status));
                pelanggaran.Status = fsm.CurrentState;

                if (fsm.CurrentState == StatusPelanggaran.DISETUJUI)
                    siswa.TotalPoin += pelanggaran.Poin;

                MessageBox.Show($"Status berhasil diubah menjadi {pelanggaran.Status}.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                siswaBindingSource.ResetBindings(false);
                pelanggaranBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengubah status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private StatusPelanggaran GetNextStatus(StatusPelanggaran current)
        {
            return current switch
            {
                StatusPelanggaran.DILAPORKAN => StatusPelanggaran.DISETUJUI,
                StatusPelanggaran.DISETUJUI => StatusPelanggaran.DIBERI_SANKSI,
                StatusPelanggaran.DIBERI_SANKSI => StatusPelanggaran.SELESAI,
                _ => current
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
