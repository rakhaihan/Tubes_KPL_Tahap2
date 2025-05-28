using API.Models;

namespace PoinSiswa_API.States
{
    public interface PoinPelanggaranState
    {
        void Handle(PoinPelanggaran poin);
    }
}
