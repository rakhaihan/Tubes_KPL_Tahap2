using PoinSiswa_API.Models;

namespace PoinSiswa_API.States
{
    // State ketika pelanggaran masih menunggu persetujuan
    public class MenungguState : IPoinPelanggaranState
    {
        public void Handle(PoinPelanggaran poin)
        {
            if (poin == null)
                throw new ArgumentNullException(nameof(poin));

            Console.WriteLine($"Pelanggaran ID {poin.Id} masih menunggu persetujuan.");
        }
    }
}
