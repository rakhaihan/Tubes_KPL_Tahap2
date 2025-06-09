using System;
using System.Text.Json.Serialization;

namespace PoinSiswa_API.Models
{
    // Model data untuk pelanggaran siswa
    public class PoinPelanggaran
    {
        public int Id { get; set; }

        public int SiswaId { get; set; }

        // Deskripsi pelanggaran, wajib diisi
        public string Deskripsi { get; set; } = string.Empty;

        public int Poin { get; set; }

        // Tanggal kejadian pelanggaran
        public DateTime Tanggal { get; set; } = DateTime.Now;

        // Status pelanggaran: Menunggu, Disetujui, atau Ditolak
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StatusPelanggaran Status { get; set; } = StatusPelanggaran.Menunggu;
    }

    // Enum status pelanggaran
    public enum StatusPelanggaran
    {
        Menunggu,
        Disetujui,
        Ditolak
    }
}
