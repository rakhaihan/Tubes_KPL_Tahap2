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
        public FormSiswa()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormSiswa_Load);
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
            // Bersihkan semua baris & kolom terlebih dahulu
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // Tambah kolom
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "NO";
            dataGridView1.Columns[1].Name = "NIS";
            dataGridView1.Columns[2].Name = "NAMA";
            dataGridView1.Columns[3].Name = "KELAS";
            dataGridView1.Columns[4].Name = "TOTAL POINT";

            // Data
            string[,] data = new string[,]
            {
        { "1", "111", "Aditya Nugraha", "10-A", "40" },
        { "2", "112", "Rakha Raihan", "10-A", "37" },
        { "3", "113", "Dimas Pratama", "10-A", "8" },
        { "4", "114", "Rina Safitri", "10-A", "6" },
        { "5", "115", "Andi Nugroho", "10-A", "5" },
        { "6", "116", "Siti Lestari", "10-A", "2" },
        { "7", "117", "Budi Santoso", "10-A", "2" },
        { "8", "118", "Maya Putri", "10-A", "0" },
        { "9", "119", "Rizky Hidayat", "10-A", "0" },
        { "10", "120", "Tina Maharani", "10-A", "0" },
        { "11", "121", "Agus Saputra", "10-A", "0" },
        { "12", "122", "Lia Kurnia", "10-A", "0" },
        { "13", "123", "Akbar Alfarizi", "10-A", "0" }



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
