using System.Collections.Generic;

namespace PoinSiswa_API.Models
{
    // Model data untuk entitas siswa
    public class Siswa
    {
        public int Id { get; set; }

        // Nama siswa, wajib diisi
        public string Nama { get; set; } = string.Empty;

        // Kelas siswa, wajib diisi
        public string Kelas { get; set; } = string.Empty;

        // Total akumulasi poin pelanggaran
        public int TotalPoin { get; set; } = 0;

        // Riwayat pelanggaran yang pernah dilakukan siswa
        public List<PoinPelanggaran> RiwayatPelanggaran { get; set; } = new();
    }
}
