using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Console.Components
{
    public static class FormBuilder
    {
        /// <summary>
        /// Menampilkan data dalam bentuk label: nilai, berdasarkan field-field yang ditentukan.
        /// </summary>
        public static void TampilkanForm<T>(Dictionary<string, Func<T, string>> fieldGenerators, T data)
        {
            // Cek apakah parameter tidak valid
            if (fieldGenerators == null || data == null)
            {
                Console.WriteLine("Data tidak dapat ditampilkan. Parameter tidak valid.");
                return;
            }

            // Menampilkan setiap field dalam bentuk "Label: Nilai"
            foreach (var field in fieldGenerators)
            {
                try
                {
                    string label = field.Key;
                    // Jalankan fungsi generator untuk mengambil nilainya, aman terhadap null
                    string nilai = field.Value?.Invoke(data) ?? "[null]";

                    Console.WriteLine($"{label}: {nilai}");
                }
                catch (Exception ex)
                {
                    // Tangani kesalahan untuk setiap field agar tidak menghentikan proses
                    Console.WriteLine($"Terjadi kesalahan saat menampilkan '{field.Key}': {ex.Message}");
                }
            }
        }
    }
}
