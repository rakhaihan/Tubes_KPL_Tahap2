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
            label3 = new Label();
            txtDeskripsi = new TextBox();
            btnSubmit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 100);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Futura Md BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(512, 34);
            label1.TabIndex = 0;
            label1.Text = "Sistem Poin Pelanggaran SMK Merdeka";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnBeranda);
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPeraturan);
            panel1.Controls.Add(btnSiswa);
            panel1.Location = new Point(1, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 980);
            panel1.TabIndex = 3;
            // 
            // btnBeranda
            // 
            btnBeranda.Font = new Font("Futura Md BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBeranda.Location = new Point(11, 20);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(250, 100);
            btnBeranda.TabIndex = 5;
            btnBeranda.Text = "BERANDA";
            btnBeranda.UseVisualStyleBackColor = true;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Font = new Font("Futura Md BT", 10.2F);
            btnLaporan.Location = new Point(11, 338);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(250, 100);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "LAPORAN";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnPeraturan
            // 
            btnPeraturan.Font = new Font("Futura Md BT", 10.2F);
            btnPeraturan.Location = new Point(11, 232);
            btnPeraturan.Name = "btnPeraturan";
            btnPeraturan.Size = new Size(250, 100);
            btnPeraturan.TabIndex = 3;
            btnPeraturan.Text = "PERATURAN";
            btnPeraturan.UseVisualStyleBackColor = true;
            btnPeraturan.Click += btnPeraturan_Click;
            // 
            // btnSiswa
            // 
            btnSiswa.Font = new Font("Futura Md BT", 10.2F);
            btnSiswa.Location = new Point(11, 126);
            btnSiswa.Name = "btnSiswa";
            btnSiswa.Size = new Size(250, 100);
            btnSiswa.TabIndex = 2;
            btnSiswa.Text = "SISWA";
            btnSiswa.UseVisualStyleBackColor = true;
            btnSiswa.Click += btnSiswa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Futura Md BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 149);
            label2.Name = "label2";
            label2.Size = new Size(171, 48);
            label2.TabIndex = 4;
            label2.Text = "Laporan";
            // 
            // lblNamaSiswa
            // 
            lblNamaSiswa.AutoSize = true;
            lblNamaSiswa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaSiswa.Location = new Point(336, 238);
            lblNamaSiswa.Name = "lblNamaSiswa";
            lblNamaSiswa.Size = new Size(121, 28);
            lblNamaSiswa.TabIndex = 5;
            lblNamaSiswa.Text = "Nama Siswa:";
            lblNamaSiswa.Click += label3_Click;
            // 
            // txtNamaSiswa
            // 
            txtNamaSiswa.Location = new Point(336, 269);
            txtNamaSiswa.Name = "txtNamaSiswa";
            txtNamaSiswa.Size = new Size(339, 27);
            txtNamaSiswa.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 344);
            label4.Name = "label4";
            label4.Size = new Size(54, 31);
            label4.TabIndex = 7;
            label4.Text = "NIS:";
            label4.Click += label4_Click;
            // 
            // txtNIS
            // 
            txtNIS.Location = new Point(336, 378);
            txtNIS.Name = "txtNIS";
            txtNIS.Size = new Size(339, 27);
            txtNIS.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(336, 468);
            label5.Name = "label5";
            label5.Size = new Size(147, 31);
            label5.TabIndex = 9;
            label5.Text = "Pelanggaran:";
            // 
            // txtPelanggaran
            // 
            txtPelanggaran.Location = new Point(336, 512);
            txtPelanggaran.Name = "txtPelanggaran";
            txtPelanggaran.Size = new Size(339, 27);
            txtPelanggaran.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(336, 595);
            label3.Name = "label3";
            label3.Size = new Size(339, 31);
            label3.TabIndex = 11;
            label3.Text = "Deskripsi Lengkap Pelanggaran:";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(336, 645);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(339, 27);
            txtDeskripsi.TabIndex = 12;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(336, 749);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(254, 29);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit Laporan";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 803);
            Controls.Add(btnSubmit);
            Controls.Add(txtDeskripsi);
            Controls.Add(label3);
            Controls.Add(txtPelanggaran);
            Controls.Add(label5);
            Controls.Add(txtNIS);
            Controls.Add(label4);
            Controls.Add(txtNamaSiswa);
            Controls.Add(lblNamaSiswa);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
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
        private Label label2;
        private Label lblNamaSiswa;
        private TextBox txtNamaSiswa;
        private Label label4;
        private TextBox txtNIS;
        private Label label5;
        private TextBox txtPelanggaran;
        private Label label3;
        private TextBox txtDeskripsi;
        private Button btnSubmit;
    }
}