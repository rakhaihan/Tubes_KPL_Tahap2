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
            this.BackColor = Color.WhiteSmoke;

            Label lblNama = new Label { Text = "Nama Siswa:", Left = 50, Top = 30, Width = 150 };
            txtNama = new TextBox { Left = 200, Top = 25, Width = 300 };

            Label lblKelas = new Label { Text = "Kelas:", Left = 50, Top = 70, Width = 150 };
            txtKelas = new TextBox { Left = 200, Top = 65, Width = 300 };

            Label lblJenis = new Label { Text = "Jenis Pelanggaran:", Left = 50, Top = 110, Width = 150 };
            cmbJenis = new ComboBox { Left = 200, Top = 105, Width = 300 };
            cmbJenis.Items.AddRange(TabelPelanggaran.Daftar.Keys.ToArray());
            cmbJenis.SelectedIndexChanged += (s, e) =>
            {
                if (cmbJenis.SelectedItem != null)
                {
                    var poin = TabelPelanggaran.GetPoin(cmbJenis.SelectedItem.ToString());
                    txtPoin.Text = poin.ToString();
                }
            };

            Label lblPoin = new Label { Text = "Poin:", Left = 50, Top = 150, Width = 150 };
            txtPoin = new TextBox { Left = 200, Top = 145, Width = 100, ReadOnly = true };

            btnSimpan = new Button { Text = "Simpan", Left = 200, Top = 190, Width = 100, BackColor = Color.MediumSeaGreen, ForeColor = Color.White };
            btnSimpan.Click += (s, e) =>
            {
                string nama = txtNama.Text.Trim();
                string kelas = txtKelas.Text.Trim();
                string jenis = cmbJenis.SelectedItem?.ToString();

                if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(kelas) || string.IsNullOrWhiteSpace(jenis))
                {
                    MessageBox.Show("Semua data harus diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int poin = TabelPelanggaran.GetPoin(jenis);

                var siswa = Program.DaftarSiswa.FirstOrDefault(s => s.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase));
                if (siswa == null)
                {
                    siswa = new Siswa { Nama = nama, Kelas = kelas };
                    Program.DaftarSiswa.Add(siswa);
                }

                var pelanggaran = new Pelanggaran
                {
                    NamaSiswa = nama,
                    Jenis = jenis,
                    Poin = poin,
                    Tanggal = DateTime.Now,
                    Status = StatusPelanggaran.DILAPORKAN
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
