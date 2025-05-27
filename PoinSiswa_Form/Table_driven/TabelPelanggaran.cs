using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa_Form.Table_driven
{
    public static class TabelPelanggaran
    {
        public static readonly Dictionary<string, JenisPelanggaran> Daftar = new()
        {
            { "Tidak Membawa Buku", new JenisPelanggaran { Nama = "Tidak Membawa Buku", Level = LevelPelanggaran.RINGAN, Poin = 5 } },
            { "Terlambat", new JenisPelanggaran { Nama = "Terlambat", Level = LevelPelanggaran.SEDANG, Poin = 10 } },
            { "Merokok", new JenisPelanggaran { Nama = "Merokok", Level = LevelPelanggaran.BERAT, Poin = 20 } }
        };

        public static int GetPoin(string nama)
        {
            if (!Daftar.ContainsKey(nama))
                throw new ArgumentException("Jenis pelanggaran tidak ditemukan");
            return Daftar[nama].Poin;
        }
    }

}
