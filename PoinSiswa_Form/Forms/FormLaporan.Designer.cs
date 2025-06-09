namespace PoinSiswa_Form.Forms
{
    partial class FormLaporan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnBeranda = new Button();
            btnLaporan = new Button();
            btnPeraturan = new Button();
            btnSiswa = new Button();
            label2 = new Label();
            lblNamaSiswa = new Label();
            txtNamaSiswa = new TextBox();
            label4 = new Label();
            txtNIS = new TextBox();
            label5 = new Label();
            txtPelanggaran = new TextBox();
            btnSubmit = new Button();
            label3 = new Label();
            txtKelas = new TextBox();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 15);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(2400, 125);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(30, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(600, 38);
            label1.TabIndex = 0;
            label1.Text = "Sistem Poin Pelanggaran SMK Merdeka";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnBeranda);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPeraturan);
            panel1.Controls.Add(btnSiswa);
            panel1.Location = new Point(1, 140);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 1225);
            panel1.TabIndex = 3;
            // 
            // btnBeranda
            // 
            btnBeranda.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeranda.Location = new Point(14, 25);
            btnBeranda.Margin = new Padding(4, 4, 4, 4);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(312, 125);
            btnBeranda.TabIndex = 5;
            btnBeranda.Text = "BERANDA";
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLaporan.Location = new Point(14, 422);
            btnLaporan.Margin = new Padding(4, 4, 4, 4);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(312, 125);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "LAPORAN";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnPeraturan
            // 
            btnPeraturan.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnPeraturan.Location = new Point(14, 290);
            btnPeraturan.Margin = new Padding(4, 4, 4, 4);
            btnPeraturan.Name = "btnPeraturan";
            btnPeraturan.Size = new Size(312, 125);
            btnPeraturan.TabIndex = 3;
            btnPeraturan.Text = "PERATURAN";
            btnPeraturan.UseVisualStyleBackColor = true;
            btnPeraturan.Click += btnPeraturan_Click;
            // 
            // btnSiswa
            // 
            btnSiswa.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnSiswa.Location = new Point(14, 158);
            btnSiswa.Margin = new Padding(4, 4, 4, 4);
            btnSiswa.Name = "btnSiswa";
            btnSiswa.Size = new Size(312, 125);
            btnSiswa.TabIndex = 2;
            btnSiswa.Text = "SISWA";
            btnSiswa.UseVisualStyleBackColor = true;
            btnSiswa.Click += btnSiswa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(396, 186);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 55);
            label2.TabIndex = 4;
            label2.Text = "Laporan";
            // 
            // lblNamaSiswa
            // 
            lblNamaSiswa.AutoSize = true;
            lblNamaSiswa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaSiswa.Location = new Point(420, 391);
            lblNamaSiswa.Margin = new Padding(4, 0, 4, 0);
            lblNamaSiswa.Name = "lblNamaSiswa";
            lblNamaSiswa.Size = new Size(147, 32);
            lblNamaSiswa.TabIndex = 5;
            lblNamaSiswa.Text = "Nama Siswa:";
            lblNamaSiswa.Click += label3_Click;
            // 
            // txtNamaSiswa
            // 
            txtNamaSiswa.BorderStyle = BorderStyle.FixedSingle;
            txtNamaSiswa.Location = new Point(420, 430);
            txtNamaSiswa.Margin = new Padding(4, 4, 4, 4);
            txtNamaSiswa.Name = "txtNamaSiswa";
            txtNamaSiswa.Size = new Size(423, 31);
            txtNamaSiswa.TabIndex = 6;
            txtNamaSiswa.TextChanged += txtNamaSiswa_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(420, 524);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 38);
            label4.TabIndex = 7;
            label4.Text = "Kelas:";
            label4.Click += label4_Click;
            // 
            // txtNIS
            // 
            txtNIS.BorderStyle = BorderStyle.FixedSingle;
            txtNIS.Location = new Point(420, 316);
            txtNIS.Margin = new Padding(4, 4, 4, 4);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(423, 31);
            txtNIS.TabIndex = 8;
            txtNIS.TextChanged += txtNIS_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(420, 649);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 38);
            label5.TabIndex = 9;
            label5.Text = "Pelanggaran:";
            // 
            // txtPelanggaran
            // 
            txtPelanggaran.BorderStyle = BorderStyle.FixedSingle;
            txtPelanggaran.Location = new Point(420, 704);
            txtPelanggaran.Margin = new Padding(4, 4, 4, 4);
            txtPelanggaran.Name = "txtPelanggaran";
            txtPelanggaran.Size = new Size(423, 31);
            txtPelanggaran.TabIndex = 10;
            txtPelanggaran.TextChanged += txtPelanggaran_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(420, 849);
            btnSubmit.Margin = new Padding(4, 4, 4, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(318, 36);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit Laporan";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(420, 278);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 14;
            label3.Text = "NIS:";
            label3.Click += label3_Click_1;
            // 
            // txtKelas
            // 
            txtKelas.BorderStyle = BorderStyle.FixedSingle;
            txtKelas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtKelas.Location = new Point(420, 566);
            txtKelas.Margin = new Padding(4, 4, 4, 4);
            txtKelas.Name = "txtKelas";
            txtKelas.Size = new Size(423, 31);
            txtKelas.TabIndex = 15;
            txtKelas.TextChanged += txtKelas_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F);
            button1.Location = new Point(14, 556);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(312, 125);
            button1.TabIndex = 6;
            button1.Text = "DATA PELANGGARAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDataPelanggaran_Click;
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 1004);
            Controls.Add(txtKelas);
            Controls.Add(label3);
            Controls.Add(btnSubmit);
            Controls.Add(txtPelanggaran);
            Controls.Add(label5);
            Controls.Add(txtNIS);
            Controls.Add(label4);
            Controls.Add(txtNamaSiswa);
            Controls.Add(lblNamaSiswa);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormLaporan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLaporan";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button btnBeranda;
        private Button btnLaporan;
        private Button btnPeraturan;
        private Button btnSiswa;
        private Button btnDataPelanggaran;
        private Label label2;
        private Label lblNamaSiswa;
        private TextBox txtNamaSiswa;
        private Label label4;
        private TextBox txtNIS;
        private Label label5;
        private TextBox txtPelanggaran;
        private Button btnSubmit;
        private Label label3;
        private TextBox txtKelas;
        private Button button1;
    }
}