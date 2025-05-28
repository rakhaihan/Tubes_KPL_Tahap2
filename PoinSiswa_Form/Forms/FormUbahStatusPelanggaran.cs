using PoinSiswa_Form.Automata;
using PoinSiswa_Form.Model;
using PoinSiswa_Form.StatePattern;
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
    public partial class FormUbahStatusPelanggaran : Form
    {
        private Label lblStatus;
        private Button btnNext;
        private PelanggaranContext context;

        public FormUbahStatusPelanggaran(Pelanggaran pelanggaran)
        {
            this.Text = "Ubah Status Pelanggaran";
            this.Size = new Size(400, 200);
            this.BackColor = Color.WhiteSmoke;

            context = new PelanggaranContext(pelanggaran);

            lblStatus = new Label
            {
                Text = $"Status: {context.GetCurrentStatus()}",
                Font = new Font("Segoe UI", 12),
                AutoSize = true,
                Top = 20,
                Left = 30
            };

            btnNext = new Button
            {
                Text = "Lanjutkan Status",
                Width = 150,
                Top = 60,
                Left = 30,
                BackColor = Color.OrangeRed,
                ForeColor = Color.White
            };
            btnNext.Click += (s, e) =>
            {
                context.NextState();
                lblStatus.Text = $"Status: {context.GetCurrentStatus()}";

                if (context.Pelanggaran.Status == StatusPelanggaran.DISETUJUI)
                {
                    var siswa = Program.DaftarSiswa.FirstOrDefault(s => s.Nama == context.Pelanggaran.NamaSiswa);
                    if (siswa != null)
                    {
                        siswa.TotalPoin += context.Pelanggaran.Poin;
                        if (siswa.TotalPoin >= 30) context.Pelanggaran.Sanksi = "Skorsing";
                        else if (siswa.TotalPoin >= 20) context.Pelanggaran.Sanksi = "Panggilan Orang Tua";
                        else if (siswa.TotalPoin >= 10) context.Pelanggaran.Sanksi = "Peringatan Lisan";
                    }
                }
            };

            Controls.Add(lblStatus);
            Controls.Add(btnNext);
        }
    }
}
