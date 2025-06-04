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
    }
}
