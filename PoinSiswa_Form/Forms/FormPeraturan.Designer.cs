namespace PoinSiswa_Form.Forms
{
    partial class FormPeraturan
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
            btnLaporan = new Button();
            btnPeraturan = new Button();
            btnSiswa = new Button();
            btnBeranda = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(2, 12);
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
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPeraturan);
            panel1.Controls.Add(btnSiswa);
            panel1.Controls.Add(btnBeranda);
            panel1.Location = new Point(2, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 980);
            panel1.TabIndex = 3;
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
            btnPeraturan.BackColor = SystemColors.GradientActiveCaption;
            btnPeraturan.Font = new Font("Futura Md BT", 10.2F);
            btnPeraturan.Location = new Point(11, 232);
            btnPeraturan.Name = "btnPeraturan";
            btnPeraturan.Size = new Size(250, 100);
            btnPeraturan.TabIndex = 3;
            btnPeraturan.Text = "PERATURAN";
            btnPeraturan.UseVisualStyleBackColor = false;
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
            // btnBeranda
            // 
            btnBeranda.BackColor = SystemColors.ButtonHighlight;
            btnBeranda.Font = new Font("Futura Md BT", 10.2F);
            btnBeranda.Location = new Point(11, 20);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(250, 100);
            btnBeranda.TabIndex = 0;
            btnBeranda.Text = "BERANDA";
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(306, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1156, 130);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Futura Md BT", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 132);
            label2.Name = "label2";
            label2.Size = new Size(218, 52);
            label2.TabIndex = 5;
            label2.Text = "Peraturan";
            // 
            // FormPeraturan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 589);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FormPeraturan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPeraturan";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button btnLaporan;
        private Button btnPeraturan;
        private Button btnSiswa;
        private Button btnBeranda;
        private DataGridView dataGridView1;
        private Label label2;
    }
}