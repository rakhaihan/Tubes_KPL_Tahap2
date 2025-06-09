namespace PoinSiswa_Form.Forms
{
    partial class FormCariDataPelanggaran
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDataPelanggaran = new Button();
            btnLaporan = new Button();
            btnPeraturan = new Button();
            btnSiswa = new Button();
            btnBeranda = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            lblHasil = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnDataPelanggaran);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPeraturan);
            panel1.Controls.Add(btnSiswa);
            panel1.Controls.Add(btnBeranda);
            panel1.Location = new Point(1, 140);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 1225);
            panel1.TabIndex = 0;
            // 
            // btnDataPelanggaran
            // 
            btnDataPelanggaran.BackColor = SystemColors.GradientActiveCaption;
            btnDataPelanggaran.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnDataPelanggaran.Location = new Point(14, 556);
            btnDataPelanggaran.Margin = new Padding(4, 3, 4, 3);
            btnDataPelanggaran.Name = "btnDataPelanggaran";
            btnDataPelanggaran.Size = new Size(313, 125);
            btnDataPelanggaran.TabIndex = 5;
            btnDataPelanggaran.Text = "DATA PELANGGARAN";
            btnDataPelanggaran.UseVisualStyleBackColor = false;
            btnDataPelanggaran.Click += btnDataPelanggaran_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLaporan.Location = new Point(14, 423);
            btnLaporan.Margin = new Padding(4, 3, 4, 3);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(313, 125);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "LAPORAN";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnPeraturan
            // 
            btnPeraturan.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnPeraturan.Location = new Point(14, 290);
            btnPeraturan.Margin = new Padding(4, 3, 4, 3);
            btnPeraturan.Name = "btnPeraturan";
            btnPeraturan.Size = new Size(313, 125);
            btnPeraturan.TabIndex = 3;
            btnPeraturan.Text = "PERATURAN";
            btnPeraturan.UseVisualStyleBackColor = true;
            btnPeraturan.Click += btnPeraturan_Click;
            // 
            // btnSiswa
            // 
            btnSiswa.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnSiswa.Location = new Point(14, 157);
            btnSiswa.Margin = new Padding(4, 3, 4, 3);
            btnSiswa.Name = "btnSiswa";
            btnSiswa.Size = new Size(313, 125);
            btnSiswa.TabIndex = 2;
            btnSiswa.Text = "SISWA";
            btnSiswa.UseVisualStyleBackColor = true;
            btnSiswa.Click += btnSiswa_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnBeranda.Location = new Point(14, 25);
            btnBeranda.Margin = new Padding(4, 3, 4, 3);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(313, 125);
            btnBeranda.TabIndex = 0;
            btnBeranda.Text = "BERANDA";
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 15);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(2400, 125);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(30, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(600, 38);
            label1.TabIndex = 0;
            label1.Text = "Sistem Poin Pelanggaran SMK Merdeka";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(417, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(261, 113);
            label2.TabIndex = 2;
            label2.Text = "Cari Data ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(502, 271);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 16;
            label3.Text = "NIS:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(565, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(750, 274);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 18;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Location = new Point(565, 347);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(50, 25);
            lblHasil.TabIndex = 19;
            lblHasil.Text = "Hasil";
            lblHasil.Click += lblHasil_Click;
            // 
            // FormCariDataPelanggaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 823);
            Controls.Add(lblHasil);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCariDataPelanggaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCariDataPelanggaran";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Button button1;
        private Button btnDataPelanggaran;
        private Button btnLaporan;
        private Button btnPeraturan;
        private Button btnSiswa;
        private Button btnBeranda;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}