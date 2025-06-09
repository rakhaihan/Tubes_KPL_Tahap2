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
            button1 = new Button();
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
            panel2.Location = new Point(2, 15);
            panel2.Margin = new Padding(4);
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
            panel1.Controls.Add(btnLaporan);
            panel1.Controls.Add(btnPeraturan);
            panel1.Controls.Add(btnSiswa);
            panel1.Controls.Add(btnBeranda);
            panel1.Location = new Point(2, 140);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 1225);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 10.2F);
            button1.Location = new Point(12, 554);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(312, 125);
            button1.TabIndex = 5;
            button1.Text = "DATA PELANGGARAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDataPelanggaran_Click;
            // 
            // btnLaporan
            // 
            btnLaporan.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnLaporan.Location = new Point(14, 422);
            btnLaporan.Margin = new Padding(4);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(312, 125);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "LAPORAN";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click;
            // 
            // btnPeraturan
            // 
            btnPeraturan.BackColor = SystemColors.GradientActiveCaption;
            btnPeraturan.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnPeraturan.Location = new Point(14, 290);
            btnPeraturan.Margin = new Padding(4);
            btnPeraturan.Name = "btnPeraturan";
            btnPeraturan.Size = new Size(312, 125);
            btnPeraturan.TabIndex = 3;
            btnPeraturan.Text = "PERATURAN";
            btnPeraturan.UseVisualStyleBackColor = false;
            // 
            // btnSiswa
            // 
            btnSiswa.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnSiswa.Location = new Point(14, 158);
            btnSiswa.Margin = new Padding(4);
            btnSiswa.Name = "btnSiswa";
            btnSiswa.Size = new Size(312, 125);
            btnSiswa.TabIndex = 2;
            btnSiswa.Text = "SISWA";
            btnSiswa.UseVisualStyleBackColor = true;
            btnSiswa.Click += btnSiswa_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = SystemColors.ButtonHighlight;
            btnBeranda.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnBeranda.Location = new Point(14, 25);
            btnBeranda.Margin = new Padding(4);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Size = new Size(312, 125);
            btnBeranda.TabIndex = 0;
            btnBeranda.Text = "BERANDA";
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(382, 242);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1445, 162);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(382, 165);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(253, 59);
            label2.TabIndex = 5;
            label2.Text = "Peraturan";
            // 
            // FormPeraturan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 806);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4);
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
        private Button btnDataPelanggaran;
        private Button btnLaporan;
        private Button btnPeraturan;
        private Button btnSiswa;
        private Button btnBeranda;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
    }
}