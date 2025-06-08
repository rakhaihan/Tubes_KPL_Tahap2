using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Console.Components
{
    public static class TableRenderer
    {
        /// <summary>
        /// Menampilkan daftar data dalam bentuk tabel dengan kolom yang ditentukan.
        /// </summary>
        public static void Render<T>(List<T> data, Dictionary<string, Func<T, string>> kolom)
        {
            // Cek apakah kolom tersedia
            if (kolom == null || kolom.Count == 0)
            {
                Console.WriteLine("Tidak ada kolom untuk ditampilkan.");
                return;
            }

            // Cek apakah data tersedia
            if (data == null || data.Count == 0)
            {
                Console.WriteLine("Tidak ada data untuk ditampilkan.");
                return;
            }

            // Tampilkan header (judul kolom)
            Console.WriteLine(string.Join(" | ", kolom.Keys));

            // Tampilkan setiap baris data
            foreach (var item in data)
            {
                try
                {
                    var baris = kolom.Values.Select(selector =>
                    {
                        try
                        {
                            // Ambil nilai dari setiap kolom, aman terhadap null
                            return selector?.Invoke(item) ?? "[null]";
                        }
                        catch (Exception ex)
                        {
                            // Tangani kesalahan per kolom agar tidak mematikan seluruh baris
                            return $"[Error: {ex.Message}]";
                        }
                    });

                    Console.WriteLine(string.Join(" | ", baris));
                }
                catch (Exception ex)
                {
                    // Tangani kesalahan jika satu baris gagal
                    Console.WriteLine($"Terjadi kesalahan saat menampilkan baris data: {ex.Message}");
                }
            }
        }
    }
}
