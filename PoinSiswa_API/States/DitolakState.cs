using PoinSiswa_API.Models;

namespace PoinSiswa_API.States
{
    // State ketika pelanggaran ditolak
    public class DitolakState : IPoinPelanggaranState
    {
        public void Handle(PoinPelanggaran poin)
        {
            if (poin == null)
                throw new ArgumentNullException(nameof(poin));

            Console.WriteLine($"Pelanggaran ID {poin.Id} telah ditolak.");
        }
    }
}
