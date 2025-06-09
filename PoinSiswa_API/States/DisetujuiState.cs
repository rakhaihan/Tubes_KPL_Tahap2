using PoinSiswa_API.Models;

namespace PoinSiswa_API.States
{
    // State ketika pelanggaran telah disetujui
    public class DisetujuiState : IPoinPelanggaranState
    {
        public void Handle(PoinPelanggaran poin)
        {
            if (poin == null)
                throw new ArgumentNullException(nameof(poin));

            Console.WriteLine($"Pelanggaran ID {poin.Id} telah disetujui.");
        }
    }
}
