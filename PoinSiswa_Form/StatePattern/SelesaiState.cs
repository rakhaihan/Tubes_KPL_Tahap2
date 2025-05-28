using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa_Form.StatePattern
{
    public class SelesaiState : IPelanggaranState
    {
        public void Next(PelanggaranContext context)
        {
            // Final state
        }

        public string GetStatus() => "SELESAI";
    }
}
