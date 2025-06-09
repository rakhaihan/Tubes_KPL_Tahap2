using PoinSiswa_API.Models;

namespace PoinSiswa_API.States
{
    // Interface untuk mendefinisikan perilaku setiap state dari pelanggaran
    public interface IPoinPelanggaranState
    {
        void Handle(PoinPelanggaran poin);
    }
}
