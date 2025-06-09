using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PoinSiswa_Form.Forms
{
    public partial class FormCariDataPelanggaran : Form
    {
        private List<Siswa> dataSiswa = new List<Siswa>
        {
            new Siswa { Id = "131", Nama = "Jack Kelvin", Kelas = "10 B", Poin = 21, Pelanggaran = new List<string>{ "Terlambat", "Tidak pakai dasi" }},
            new Siswa { Id = "132", Nama = "Muhammad Azki", Kelas = "10 B", Poin = 30, Pelanggaran = new List<string>{ "Merokok" }},
            new Siswa { Id = "111", Nama = "Aditya Nugraha", Kelas = "10 A", Poin = 40, Pelanggaran = new List<string>{ "Merokok", "Bolos" }},
            new Siswa { Id = "132", Nama = "Muhammad Raihan", Kelas = "10 C", Poin = 28, Pelanggaran = new List<string>{ "Bolos" }},
        };

        private class Siswa
        {
            public string Id { get; set; }
            public string Nama { get; set; }
            public string Kelas { get; set; }
            public int Poin { get; set; }
            public List<string> Pelanggaran { get; set; }
        }

        public FormCariDataPelanggaran()
        {
            InitializeComponent();
            lblHasil.Location = new Point(textBox1.Left, textBox1.Bottom + 40);
            lblHasil.Size = new Size(400, 200);
            lblHasil.AutoSize = false;
            lblHasil.Font = new Font("Segoe UI", 10);
            lblHasil.ForeColor = Color.Black;
            lblHasil.Text = "";
        }

       

        private void btnBeranda_Click(object sender, EventArgs e) { }

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

        private void FormCariDataPelanggaran_Load(object sender, EventArgs e) { }

        private void txtNIS_TextChanged(object sender, EventArgs e) { }

        // Variabel kontrol UI (harus cocok dengan di Designer)
        private TextBox txtNIS;
        private Button btnSubmit;
        private Label lblHasil;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idDicari = textBox1.Text.Trim();
            var siswa = dataSiswa.FirstOrDefault(s => s.Id.Equals(idDicari, StringComparison.OrdinalIgnoreCase));

            if (siswa != null)
            {
                lblHasil.Text = $"Nama: {siswa.Nama}\n" +
                                $"Kelas: {siswa.Kelas}\n" +
                                $"Poin: {siswa.Poin}\n" +
                                $"Pelanggaran:\n- {string.Join("\n- ", siswa.Pelanggaran)}";
            }
            else
            {
                lblHasil.Text = "Data tidak ditemukan.";
            }
        }

        private void lblHasil_Click(object sender, EventArgs e)
        {
            lblHasil.Text = "";
        }
    }
}
