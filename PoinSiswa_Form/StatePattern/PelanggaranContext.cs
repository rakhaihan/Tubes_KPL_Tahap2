using PoinSiswa_Form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa_Form.StatePattern
{
    public class PelanggaranContext
    {
        private IPelanggaranState _state;
        public Pelanggaran Pelanggaran { get; set; }

        public PelanggaranContext(Pelanggaran pelanggaran)
        {
            Pelanggaran = pelanggaran;
            switch (pelanggaran.Status)
            {
                case StatusPelanggaran.DILAPORKAN:
                    _state = new DilaporkanState(); break;
                case StatusPelanggaran.DISETUJUI:
                    _state = new DisetujuiState(); break;
                case StatusPelanggaran.DIBERI_SANKSI:
                    _state = new DiberiSanksiState(); break;
                case StatusPelanggaran.SELESAI:
                    _state = new SelesaiState(); break;
            }
        }

        public void SetState(IPelanggaranState state) => _state = state;

        public void NextState() => _state.Next(this);

        public string GetCurrentStatus() => _state.GetStatus();
    }
}
