using API.Models;

namespace PoinSiswa_API.States
{
    public class PoinPelanggaranContext
    {
        private PoinPelanggaranState _state;

        public void SetState(PoinPelanggaranState state)
        {
            _state = state;
        }

        public void ApplyState(PoinPelanggaran poin)
        {
            _state?.Handle(poin);
        }
    }
}
