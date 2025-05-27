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
    public partial class FormMain : Form
    {
        private Button btnTambahPelanggaran;
        private Button btnLihatRiwayat;

        public FormMain()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Menu Utama - Sistem Poin Siswa";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.WhiteSmoke;

            Label title = new Label
            {
                Text = "SISTEM POIN PELANGGARAN SISWA",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.DarkSlateBlue,
                AutoSize = true,
                Location = new Point(100, 30)
            };

            btnTambahPelanggaran = new Button
            {
                Text = "Tambah Pelanggaran Siswa",
                Font = new Font("Segoe UI", 14),
                Width = 300,
                Height = 60,
                Location = new Point(100, 120),
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White
            };
            btnTambahPelanggaran.Click += (s, e) => new FormTambahPelanggaran().ShowDialog();

            btnLihatRiwayat = new Button
            {
                Text = "Lihat Riwayat Pelanggaran",
                Font = new Font("Segoe UI", 14),
                Width = 300,
                Height = 60,
                Location = new Point(100, 200),
                BackColor = Color.CadetBlue,
                ForeColor = Color.White
            };
            btnLihatRiwayat.Click += (s, e) => new FormRiwayatPelanggaran().ShowDialog();

            Controls.Add(title);
            Controls.Add(btnTambahPelanggaran);
            Controls.Add(btnLihatRiwayat);
        }
    }
}
