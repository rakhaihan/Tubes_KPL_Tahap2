using System;
using System.Collections.Generic;

namespace PoinSiswa_Form.Table_driven
{
    public static class TabelPelanggaran
    {
        // Clean code: gunakan IReadOnlyDictionary untuk mencegah modifikasi dari luar
        public static IReadOnlyDictionary<string, JenisPelanggaran> Daftar { get; } =
            new Dictionary<string, JenisPelanggaran>(StringComparer.OrdinalIgnoreCase)
            {
                {
                    "Tidak Membawa Buku", new JenisPelanggaran
                    {
                        Nama = "Tidak Membawa Buku",
                        Level = LevelPelanggaran.RINGAN,
                        Poin = 5
                    }
                },
                {
                    "Terlambat", new JenisPelanggaran
                    {
                        Nama = "Terlambat",
                        Level = LevelPelanggaran.SEDANG,
                        Poin = 10
                    }
                },
                {
                    "Merokok", new JenisPelanggaran
                    {
                        Nama = "Merokok",
                        Level = LevelPelanggaran.BERAT,
                        Poin = 20
                    }
                }
            };

        public static int GetPoin(string nama)
        {
            // Secure coding: validasi null/whitespace
            if (string.IsNullOrWhiteSpace(nama))
                throw new ArgumentException("Nama pelanggaran tidak boleh kosong atau null.", nameof(nama));

            // Secure coding: gunakan TryGetValue untuk menghindari KeyNotFoundException
            return Daftar.TryGetValue(nama, out var jenis)
                ? jenis.Poin
                : throw new KeyNotFoundException($"Jenis pelanggaran '{nama}' tidak ditemukan.");
        }
    }
}
