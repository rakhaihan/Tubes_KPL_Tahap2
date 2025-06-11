namespace PoinSiswa_Form.Forms
{
    partial class FormBeranda
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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel1.Location = new Point(1, 84);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 735);
            panel1.TabIndex = 0;
            // 
            // btnDataPelanggaran
            // 
            btnDataPelanggaran.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnDataPelanggaran.Location = new Point(10, 334);
            btnDataPelanggaran.Margin = new Padding(3, 2, 3, 2);
            btnDataPelanggaran.Name = "btnDataPelanggaran";
            btnDataPelanggaran.Size = new Size(219, 75);
            btnDataPelanggaran.TabIndex = 5;
            btnDataPelanggaran.Text = "DATA PELANGGARAN";
            btnDataPelanggaran.UseVisualStyleBackColor = true;
            btnDataPelanggaran.Click += btnDataPelanggaran_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLaporan.Location = new Point(10, 254);
            btnLaporan.Margin = new Padding(3, 2, 3, 2);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(219, 75);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "LAPORAN";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnPeraturan
            // 
            btnPeraturan.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnPeraturan.Location = new Point(10, 174);
            btnPeraturan.Margin = new Padding(3, 2, 3, 2);
            btnPeraturan.Name = "btnPeraturan";
            btnPeraturan.Size = new Size(219, 75);
            btnPeraturan.TabIndex = 3;
            btnPeraturan.Text = "PERATURAN";
            btnPeraturan.UseVisualStyleBackColor = true;
            btnPeraturan.Click += btnPeraturan_Click;
            // 
            // btnSiswa
            // 
            btnSiswa.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnSiswa.Location = new Point(10, 94);
            btnSiswa.Margin = new Padding(3, 2, 3, 2);
            btnSiswa.Name = "btnSiswa";
            btnSiswa.Size = new Size(219, 75);
            btnSiswa.TabIndex = 2;
            btnSiswa.Text = "SISWA";
            btnSiswa.UseVisualStyleBackColor = true;
            btnSiswa.Click += btnSiswa_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = SystemColors.GradientActiveCaption;
            btnBeranda.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnBeranda.Location = new Point(10, 15);
            btnBeranda.Margin = new Padding(3, 2, 3, 2);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(219, 75);
            btnBeranda.TabIndex = 0;
            btnBeranda.Text = "BERANDA";
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1680, 75);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(403, 26);
            label1.TabIndex = 0;
            label1.Text = "Sistem Poin Pelanggaran SMK Merdeka";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 30F);
            label2.Location = new Point(292, 99);
            label2.Name = "label2";
            label2.Size = new Size(183, 68);
            label2.TabIndex = 0;
            label2.Text = "Beranda";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(292, 191);
            label3.Name = "label3";
            label3.Size = new Size(232, 37);
            label3.TabIndex = 2;
            label3.Text = "Berita Kasus Siswa";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.merokok;
            pictureBox1.Location = new Point(292, 297);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 170);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(292, 258);
            label4.Name = "label4";
            label4.Size = new Size(282, 28);
            label4.TabIndex = 4;
            label4.Text = "Aditya Nugraha 10-A Merokok";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveBorder;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(579, 297);
            label5.Name = "label5";
            label5.Size = new Size(378, 63);
            label5.TabIndex = 5;
            label5.Text = "Aditya Nugraha tertangkap kamera sedang merokok \r\nbersama dua rekannya di area terbuka yang diduga \r\nmasih berada di lingkungan sekolah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveBorder;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(292, 511);
            label6.Name = "label6";
            label6.Size = new Size(352, 28);
            label6.TabIndex = 6;
            label6.Text = "Rakha Raihanurrahman 10-A Terlambat";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.terlambat;
            pictureBox3.Location = new Point(292, 551);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(281, 170);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveBorder;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(579, 551);
            label7.Name = "label7";
            label7.Size = new Size(325, 42);
            label7.TabIndex = 8;
            label7.Text = "Rakha Raihanurrahman sedang menjalankan \r\nhukuman karena datang terlambat";
            label7.Click += label7_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(272, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(1409, 641);
            panel3.TabIndex = 9;
            // 
            // FormBeranda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 762);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBeranda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBeranda";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnDataPelanggaran;
        private Button btnLaporan;
        private Button btnPeraturan;
        private Button btnSiswa;
        private Button btnBeranda;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
        private Panel panel3;
    }
}