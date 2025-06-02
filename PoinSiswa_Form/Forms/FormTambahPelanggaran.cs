using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoinSiswa_Form.Table_driven;
using PoinSiswa_Form.Model;


namespace PoinSiswa_Form.Forms
{
    public partial class FormTambahPelanggaran : Form
    {
        private TextBox txtNama;
        private TextBox txtKelas;
        private ComboBox cmbJenis;
        private TextBox txtPoin;
        private Button btnSimpan;

        public FormTambahPelanggaran()
        {
            this.Text = "Tambah Pelanggaran";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            Label lblNama = new Label { Text = "Nama Siswa:", Left = 50, Top = 30, Width = 150 };
            txtNama = new TextBox { Left = 200, Top = 25, Width = 300 };

            Label lblKelas = new Label { Text = "Kelas:", Left = 50, Top = 70, Width = 150 };
            txtKelas = new TextBox { Left = 200, Top = 65, Width = 300 };

            Label lblJenis = new Label { Text = "Jenis Pelanggaran:", Left = 50, Top = 110, Width = 150 };
            cmbJenis = new ComboBox { Left = 200, Top = 105, Width = 300 };
            cmbJenis.Items.AddRange(TabelPelanggaran.Daftar.Keys.ToArray());

            cmbJenis.SelectedIndexChanged += (s, e) =>
            {
                if (cmbJenis.SelectedItem is string selectedJenis &&
                    TabelPelanggaran.Daftar.TryGetValue(selectedJenis, out var jenis))
                {
                    txtPoin.Text = jenis.Poin.ToString();
                }
            };

            Label lblPoin = new Label { Text = "Poin:", Left = 50, Top = 150, Width = 150 };
            txtPoin = new TextBox { Left = 200, Top = 145, Width = 100, ReadOnly = true };

            btnSimpan = new Button { Text = "Simpan", Left = 200, Top = 190, Width = 100, BackColor = System.Drawing.Color.MediumSeaGreen, ForeColor = System.Drawing.Color.White };
            btnSimpan.Click += (s, e) =>
            {
                string nama = txtNama.Text.Trim();
                string kelas = txtKelas.Text.Trim();
                string jenisNama = cmbJenis.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(kelas) || string.IsNullOrWhiteSpace(jenisNama))
                {
                    MessageBox.Show("Semua data harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!TabelPelanggaran.Daftar.TryGetValue(jenisNama, out var jenis))
                {
                    MessageBox.Show("Jenis pelanggaran tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var siswa = Program.DaftarSiswa.FirstOrDefault(s => s.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase));
                if (siswa == null)
                {
                    siswa = new Siswa { Id = Guid.NewGuid().GetHashCode(), Nama = nama, Kelas = kelas };
                    Program.DaftarSiswa.Add(siswa);
                }

                var pelanggaran = new Pelanggaran
                {
                    Id = Guid.NewGuid().GetHashCode(),
                    SiswaId = siswa.Id,
                    NamaSiswa = nama,
                    KelasSiswa = kelas,
                    Jenis = jenis.Nama,
                    Poin = jenis.Poin,
                    Tanggal = DateTime.Now,
                    Status = StatusPelanggaran.DILAPORKAN,
                    Sanksi = ""
                };

                siswa.RiwayatPelanggaran.Add(pelanggaran);
                Program.SemuaPelanggaran.Add(pelanggaran);

                MessageBox.Show("Pelanggaran berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            };

            Controls.Add(lblNama);
            Controls.Add(txtNama);
            Controls.Add(lblKelas);
            Controls.Add(txtKelas);
            Controls.Add(lblJenis);
            Controls.Add(cmbJenis);
            Controls.Add(lblPoin);
            Controls.Add(txtPoin);
            Controls.Add(btnSimpan);
        }
    }
}
