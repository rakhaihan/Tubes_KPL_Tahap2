using API.Models;

namespace PoinSiswa_API.States
{
    public class DitolakState : PoinPelanggaranState
    {
        public void Handle(PoinPelanggaran poin)
        {
            Console.WriteLine($"Pelanggaran ID {poin.Id} telah ditolak.");
        }
    }
}
