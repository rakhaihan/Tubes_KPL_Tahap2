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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            this.btnBeranda = new Button();
            this.btnSiswa = new Button();
            this.btnPeraturan = new Button();
            btnLaporan = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Futura Md BT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(512, 34);
            label1.TabIndex = 1;
            label1.Text = "Sistem Poin Pelanggaran SMK Merdeka";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(btnLaporan);
            panel2.Controls.Add(this.btnPeraturan);
            panel2.Controls.Add(this.btnSiswa);
            panel2.Controls.Add(this.btnBeranda);
            panel2.Location = new Point(1, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(286, 1080);
            panel2.TabIndex = 1;
            // 
            // btnBeranda
            // 
            this.btnBeranda.Font = new Font("Futura Md BT", 10.2F);
            this.btnBeranda.Location = new Point(11, 20);
            this.btnBeranda.Name = "btnBeranda";
            this.btnBeranda.Size = new Size(250, 100);
            this.btnBeranda.TabIndex = 0;
            this.btnBeranda.Text = "BERANDA";
            this.btnBeranda.UseVisualStyleBackColor = true;
            this.btnBeranda.Click += this.button1_Click;
            // 
            // btnSiswa
            // 
            this.btnSiswa.Font = new Font("Futura Md BT", 10.2F);
            this.btnSiswa.Location = new Point(11, 126);
            this.btnSiswa.Name = "btnSiswa";
            this.btnSiswa.Size = new Size(250, 100);
            this.btnSiswa.TabIndex = 1;
            this.btnSiswa.Text = "SISWA";
            this.btnSiswa.UseVisualStyleBackColor = true;
            this.btnSiswa.Click += this.button2_Click;
            // 
            // btnPeraturan
            // 
            this.btnPeraturan.Font = new Font("Futura Md BT", 10.2F);
            this.btnPeraturan.Location = new Point(11, 232);
            this.btnPeraturan.Name = "btnPeraturan";
            this.btnPeraturan.Size = new Size(250, 100);
            this.btnPeraturan.TabIndex = 2;
            this.btnPeraturan.Text = "PERATURAN";
            this.btnPeraturan.UseVisualStyleBackColor = true;
            this.btnPeraturan.Click += this.button3_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Font = new Font("Futura Md BT", 10.2F);
            btnLaporan.Location = new Point(11, 338);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(250, 100);
            btnLaporan.TabIndex = 3;
            btnLaporan.Text = "LAPORAN";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += button4_Click;
            // 
            // FormLaporan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 612);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormLaporan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLaporan";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnLaporan;
    }
}