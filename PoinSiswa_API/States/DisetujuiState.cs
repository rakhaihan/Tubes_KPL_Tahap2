using API.Models;

namespace PoinSiswa_API.States
{
    public class DisetujuiState : PoinPelanggaranState
    {
        public void Handle(PoinPelanggaran poin)
        {
            // Tambahkan logika dampak ke siswa jika perlu
            Console.WriteLine($"Pelanggaran ID {poin.Id} telah disetujui.");
        }
    }
}
