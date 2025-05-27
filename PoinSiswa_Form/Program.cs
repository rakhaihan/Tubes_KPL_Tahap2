using System;
using System.Windows.Forms;
using System.Windows.Forms;
using PoinSiswa_Form.Model;

namespace PoinSiswa_Form
{
    static class Program
    {
        public static List<Siswa> DaftarSiswa = new();
        public static List<Pelanggaran> SemuaPelanggaran = new();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FormMain());
        }
    }
}