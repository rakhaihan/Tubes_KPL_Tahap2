using System;
using System.Text.Json.Serialization;
namespace API.Models
{
    public class PoinPelanggaran
    {
        public int Id { get; set; }
        public int SiswaId { get; set; }
        public string Deskripsi { get; set; }
        public int Poin { get; set; }
        public DateTime Tanggal { get; set; } = DateTime.Now;

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StatusPelanggaran Status { get; set; } = StatusPelanggaran.Menunggu;
    }

    public enum StatusPelanggaran
    {
        Menunggu,
        Disetujui,
        Ditolak
    }
}
