using PoinSiswa_Form.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa_Form.StatePattern
{
    public class DiberiSanksiState : IPelanggaranState
    {
        public void Next(PelanggaranContext context)
        {
            context.SetState(new SelesaiState());
            context.Pelanggaran.Status = StatusPelanggaran.SELESAI;
        }

        public string GetStatus() => "DIBERI SANKSI";
    }
}
