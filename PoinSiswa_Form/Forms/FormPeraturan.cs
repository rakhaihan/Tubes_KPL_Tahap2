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
    public partial class FormPeraturan : Form
    {
        public FormPeraturan()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormPeraturan_Load);
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

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            var form = new FormLaporan();
            form.Show();
            this.Hide();
        }

        private void btnDataPelanggaran_Click (object sender, EventArgs e)
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

        private void FormPeraturan_Load(object sender, EventArgs e)
        {
            // Bersihkan semua baris & kolom terlebih dahulu
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Tambah kolom
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "No";
            dataGridView1.Columns[1].Name = "Kode";
            dataGridView1.Columns[2].Name = "Peraturan";
            dataGridView1.Columns[3].Name = "Total Point";
            dataGridView1.Columns[4].Name = "Level Pelanggaran";

            // Data
            string[,] data = new string[,]
            {
        { "1", "P02", "Tidak Membawa Buku", "5", "RINGAN" },
        { "2", "P05", "Terlambat", "10", "SEDANG" },
        { "3", "P08", "Merokok", "20", "BERAT" },
            };

            // Tambah data ke DataGridView
            for (int i = 0; i < data.GetLength(0); i++)
            {
                string[] row = new string[5];
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row[j] = data[i, j];
                }
                dataGridView1.Rows.Add(row);
            }

            // Opsi tampilan
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
