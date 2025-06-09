using PoinSiswa_API.Models;

namespace PoinSiswa_API.States
{
    // Kelas ini mengatur state aktif dan menerapkan state tersebut ke pelanggaran
    public class PoinPelanggaranContext
    {
        private IPoinPelanggaranState? _state; // Menyimpan state saat ini

        // Mengatur state baru
        public void SetState(IPoinPelanggaranState state)
        {
            _state = state ?? throw new ArgumentNullException(nameof(state));
        }

        // Menerapkan aksi berdasarkan state saat ini ke data pelanggaran
        public void ApplyState(PoinPelanggaran poin)
        {
            if (poin == null)
                throw new ArgumentNullException(nameof(poin));

            if (_state == null)
                throw new InvalidOperationException("State belum diatur.");

            _state.Handle(poin);
        }
    }
}
