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
            btnLaporan = new Button();
            btnPeraturan = new Button();
            btnSiswa = new Button();
            btnBeranda = new Button();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(292, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(667, 281);
            dataGridView1.TabIndex = 2;
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
            // FormBeranda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 479);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormBeranda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBeranda";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnLaporan;
        private Button btnPeraturan;
        private Button btnSiswa;
        private Button btnBeranda;
        private DataGridView dataGridView1;
        private Label label2;
    }
}