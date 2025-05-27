using System;
using System.Windows.Forms;

namespace PoinSiswa_Form
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }

    public class FormMain : Form
    {
        private Button btnTambahPelanggaran;
        private Button btnUbahStatus;

        public FormMain()
        {
            Text = "Menu Utama";
            Width = 300;
            Height = 200;

            btnTambahPelanggaran = new Button { Text = "Tambah Pelanggaran", Top = 20, Left = 50, Width = 180 };
            btnTambahPelanggaran.Click += (s, e) => new FormTambahPelanggaran().ShowDialog();

            btnUbahStatus = new Button { Text = "Ubah Status Pelanggaran", Top = 60, Left = 50, Width = 180 };
            btnUbahStatus.Click += (s, e) => new FormUbahStatusPelanggaran().ShowDialog();

            Controls.Add(btnTambahPelanggaran);
            Controls.Add(btnUbahStatus);
        }
    }

    public class FormTambahPelanggaran : Form
    {
        private ComboBox cmbJenis;
        private TextBox txtPoin;
        private Button btnSimpan;

        public FormTambahPelanggaran()
        {
            Text = "Tambah Pelanggaran";
            Width = 300;
            Height = 200;

            cmbJenis = new ComboBox { Left = 20, Top = 20, Width = 200 };
            cmbJenis.Items.AddRange(PoinSiswa_Form.Table_driven.TabelPelanggaran.Daftar.Keys.ToArray());
            cmbJenis.SelectedIndexChanged += (s, e) =>
            {
                var jenis = cmbJenis.SelectedItem?.ToString();
                if (jenis != null)
                {
                    var poin = PoinSiswa_Form.Table_driven.TabelPelanggaran.GetPoin(jenis);
                    txtPoin.Text = poin.ToString();
                }
            };

            txtPoin = new TextBox { Left = 20, Top = 60, Width = 100, ReadOnly = true };
            btnSimpan = new Button { Text = "Simpan", Left = 20, Top = 100, Width = 100 };

            Controls.Add(cmbJenis);
            Controls.Add(txtPoin);
            Controls.Add(btnSimpan);
        }
    }

    public class FormUbahStatusPelanggaran : Form
    {
        private Label lblStatus;
        private ComboBox cmbTrigger;
        private Button btnUbah;
        private PoinSiswa_Form.Automata.PelanggaranStateMachine fsm;

        public FormUbahStatusPelanggaran()
        {
            Text = "Ubah Status Pelanggaran";
            Width = 300;
            Height = 200;

            fsm = new PoinSiswa_Form.Automata.PelanggaranStateMachine();

            lblStatus = new Label { Left = 20, Top = 20, Width = 250, Text = $"Status Sekarang: {fsm.CurrentState}" };
            cmbTrigger = new ComboBox { Left = 20, Top = 50, Width = 200 };
            cmbTrigger.Items.AddRange(Enum.GetNames(typeof(PoinSiswa_Form.Automata.Trigger)));

            btnUbah = new Button { Text = "Ubah Status", Left = 20, Top = 90, Width = 120 };
            btnUbah.Click += (s, e) =>
            {
                try
                {
                    var trigger = (PoinSiswa_Form.Automata.Trigger)Enum.Parse(typeof(PoinSiswa_Form.Automata.Trigger), cmbTrigger.SelectedItem.ToString());
                    fsm.Activate(trigger);
                    lblStatus.Text = $"Status Sekarang: {fsm.CurrentState}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };

            Controls.Add(lblStatus);
            Controls.Add(cmbTrigger);
            Controls.Add(btnUbah);
        }
    }
}
