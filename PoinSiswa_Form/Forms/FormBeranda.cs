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
    public partial class FormBeranda : Form
    {

        public FormBeranda()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormBeranda_Load);
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {

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
            var form = new FormLaporan();
            form.Show();
            this.Hide();
        }

        private void FormBeranda_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "No";
            dataGridView1.Columns[1].Name = "NIS";
            dataGridView1.Columns[2].Name = "Nama";
            dataGridView1.Columns[3].Name = "Kelas";
            dataGridView1.Columns[4].Name = "Total Point";

            string[,] data = new string[,]
            {
        { "1", "111", "Aditya Nugraha", "10-A", "40" },
        { "2", "112", "Rakha Raihan", "10-A", "37" },
        { "3", "131", "Jack Kelvin", "10-B", "34" },
        { "4", "132", "Muhammad Azki", "10-B", "30" },
        { "5", "141", "Muhammad Raihan", "10-C", "28" },
        { "6", "142", "Jack Kibo", "10-C", "21" },
        { "7", "151", "Anak Agung", "11-A", "20" },
        { "8", "152", "Fadli Achsan", "11-A", "19" },
        { "9", "161", "Khalish Tianto", "11-B", "19" },
        { "10", "162", "Bintang Anugrah", "11-B", "18" },
            };

            for (int i = 0; i < data.GetLength(0); i++)
            {
                string[] row = new string[5];
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row[j] = data[i, j];
                }
                dataGridView1.Rows.Add(row);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
