using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa_Form.Model
{
    public enum StatusPelanggaran { 
        DILAPORKAN, 
        DISETUJUI, 
        DIBERI_SANKSI, 
        SELESAI 
    }

    public class Pelanggaran
    {
        public int Id { get; set; }
        public int SiswaId { get; set; }
        public string NamaSiswa { get; set; } = string.Empty;
        public string KelasSiswa { get; set; } = string.Empty;
        public string Jenis { get; set; } = string.Empty;
        public int Poin { get; set; }
        public DateTime Tanggal { get; set; }
        public StatusPelanggaran Status { get; set; } = StatusPelanggaran.DILAPORKAN;
        public string Sanksi { get; set; } = string.Empty;
    }

}

