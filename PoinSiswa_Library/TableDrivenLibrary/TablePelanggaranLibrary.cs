using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.TableDrivenLibrary
{
    /// <summary>
    /// Tabel referensi jenis pelanggaran dan poinnya.
    /// </summary>
    public static class TabelPelanggaran
    {
        /// <summary>
        /// Dictionary daftar jenis pelanggaran yang tersedia.
        /// </summary>
        public static readonly Dictionary<string, JenisPelanggaran> Daftar = new Dictionary<string, JenisPelanggaran>
            {
                { "Tidak Membawa Buku", new JenisPelanggaran("Tidak Membawa Buku", LevelPelanggaran.RINGAN, 5) },
                { "Terlambat Masuk", new JenisPelanggaran("Terlambat Masuk", LevelPelanggaran.SEDANG, 10) },
                { "Merokok", new JenisPelanggaran("Merokok", LevelPelanggaran.BERAT, 20) }
            };

        /// <summary>
        /// Mengambil poin pelanggaran berdasarkan nama.
        /// </summary>
        /// <param name="nama">Nama pelanggaran.</param>
        /// <returns>Poin dari pelanggaran.</returns>
        public static int GetPoin(string nama)
        {
            // === Secure Coding ===
            // Validasi input string dan pastikan pelanggaran terdaftar
            if (string.IsNullOrWhiteSpace(nama))
                throw new ArgumentException("Nama pelanggaran tidak boleh kosong atau null.", nameof(nama));

            if (!Daftar.TryGetValue(nama, out var pelanggaran))
                throw new KeyNotFoundException($"Pelanggaran '{nama}' tidak ditemukan dalam daftar.");

            return pelanggaran.Poin;
        }
    }

}
