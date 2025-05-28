using PoinSiswa_Form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa_Form.StatePattern
{
    public class DilaporkanState : IPelanggaranState
    {
        public void Next(PelanggaranContext context)
        {
            context.SetState(new DisetujuiState());
            context.Pelanggaran.Status = StatusPelanggaran.DISETUJUI;
        }

        public string GetStatus() => "DILAPORKAN";
    }
}
