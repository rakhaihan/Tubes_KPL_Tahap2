using PoinSiswa_Form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa_Form.StatePattern
{
    public class DisetujuiState : IPelanggaranState
    {
        public void Next(PelanggaranContext context)
        {
            context.SetState(new DiberiSanksiState());
            context.Pelanggaran.Status = StatusPelanggaran.DIBERI_SANKSI;
        }

        public string GetStatus() => "DISETUJUI";
    }
}
