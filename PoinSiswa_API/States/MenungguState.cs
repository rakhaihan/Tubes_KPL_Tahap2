using API.Models;

namespace PoinSiswa_API.States
{
    public class MenungguState : PoinPelanggaranState
    {
        public void Handle(PoinPelanggaran poin)
        {
            // Bisa ditambahkan logika notifikasi ke guru, misalnya
            Console.WriteLine($"Pelanggaran ID {poin.Id} masih menunggu persetujuan.");
        }
    }
}
