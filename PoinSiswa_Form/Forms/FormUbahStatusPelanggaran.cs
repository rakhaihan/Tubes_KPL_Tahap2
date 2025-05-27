using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoinSiswa_Form.Automata;
using PoinSiswa_Form.Model;

namespace PoinSiswa_Form.Forms
{
    public partial class FormUbahStatusPelanggaran : Form
    {
        private Label lblStatus;
        private ComboBox cmbTrigger;
        private Button btnUbah;
        private PelanggaranStateMachine fsm;
        private Pelanggaran pelanggaran;

        public FormUbahStatusPelanggaran(Pelanggaran pelanggaran)
        {
            this.pelanggaran = pelanggaran;
            this.fsm = new PelanggaranStateMachine();
            this.fsm.ActivateTo(pelanggaran.Status); // optional: buat method ActivateTo jika ingin mulai dari status yang benar

            this.Text = "Ubah Status Pelanggaran";
            this.Size = new Size(500, 300);
            this.BackColor = Color.WhiteSmoke;

            lblStatus = new Label { Left = 20, Top = 20, Width = 400, Font = new Font("Segoe UI", 12), Text = $"Status Saat Ini: {fsm.CurrentState}" };
            cmbTrigger = new ComboBox { Left = 20, Top = 60, Width = 300 };
            cmbTrigger.Items.AddRange(Enum.GetNames(typeof(Trigger)));

            btnUbah = new Button { Text = "Ubah Status", Left = 20, Top = 100, Width = 150, BackColor = Color.DarkOrange, ForeColor = Color.White };
            btnUbah.Click += (s, e) =>
            {
                try
                {
                    var trigger = (Trigger)Enum.Parse(typeof(Trigger), cmbTrigger.SelectedItem.ToString());
                    fsm.Activate(trigger);
                    pelanggaran.Status = fsm.CurrentState;
                    lblStatus.Text = $"Status Saat Ini: {pelanggaran.Status}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            Controls.Add(lblStatus);
            Controls.Add(cmbTrigger);
            Controls.Add(btnUbah);
        }
    }
}
