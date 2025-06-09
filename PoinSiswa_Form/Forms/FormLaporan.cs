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
using PoinSiswa_Form.Table_driven;

namespace PoinSiswa_Form.Forms
{
    public partial class FormLaporan : Form
    {
        public FormLaporan()
        {
            InitializeComponent();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            var form = new FormBeranda();
            form.Show();
            this.Hide();
        }

        private void btnSiswa_Click(object sender, EventArgs e)
        {
            var form = new FormSiswa();
            form.Show();
            this.Hide();
        }

        private void btnPeraturan_Click(object sender, EventArgs e)
        {
            var form = new FormPeraturan();
            form.Show();
            this.Hide();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {

        }

        private void btnDataPelanggaran_Click(object sender, EventArgs e)
        {
            var form = new FormCariDataPelanggaran();
            form.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //btnSubmit
        private void button1_Click(object sender, EventArgs e)
        {
            string nama = txtNamaSiswa.Text.Trim();
            string nisText = txtNIS.Text.Trim();
            string kelas = txtKelas.Text.Trim();
            string jenisPelanggaran = txtPelanggaran.Text.Trim();

            // Validasi input
            if (string.IsNullOrWhiteSpace(nama) ||
                string.IsNullOrWhiteSpace(nisText) ||
                string.IsNullOrWhiteSpace(kelas) ||
                string.IsNullOrWhiteSpace(jenisPelanggaran))
            {
                MessageBox.Show("Semua field harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(nisText, out int nis))
            {
                MessageBox.Show("NIS harus berupa angka.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi jenis pelanggaran
            if (!TabelPelanggaran.Daftar.TryGetValue(jenisPelanggaran, out var jenis))
            {
                MessageBox.Show("Jenis pelanggaran tidak ditemukan dalam daftar aturan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cari siswa berdasarkan NIS
            var siswa = Program.DaftarSiswa.FirstOrDefault(s => s.Id == nis);

            if (siswa == null)
            {
                // Jika siswa belum ada, tambahkan
                siswa = new Siswa
                {
                    Id = nis,
                    Nama = nama,
                    Kelas = kelas
                };
                Program.DaftarSiswa.Add(siswa);
            }
            else
            {
                // Jika siswa sudah ada tapi kelas belum terisi, update kelas
                if (string.IsNullOrWhiteSpace(siswa.Kelas))
                    siswa.Kelas = kelas;
            }

            // Buat data pelanggaran
            var pelanggaran = new Pelanggaran
            {
                Id = Guid.NewGuid().GetHashCode(),
                SiswaId = siswa.Id,
                NamaSiswa = siswa.Nama,
                KelasSiswa = siswa.Kelas,
                Jenis = jenis.Nama,
                Poin = jenis.Poin,
                Tanggal = DateTime.Now,
                Status = StatusPelanggaran.DILAPORKAN,
                Sanksi = ""
            };

            siswa.RiwayatPelanggaran.Add(pelanggaran);
            Program.SemuaPelanggaran.Add(pelanggaran);

            MessageBox.Show("Pelanggaran berhasil ditambahkan ke siswa.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Bersihkan input
            txtNamaSiswa.Clear();
            txtNIS.Clear();
            txtKelas.Clear();
            txtPelanggaran.Clear();
        }

        private void txtNamaSiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPelanggaran_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtKelas_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
