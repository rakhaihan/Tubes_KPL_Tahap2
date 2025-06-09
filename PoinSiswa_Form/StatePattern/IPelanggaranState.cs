using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa_Form.StatePattern
{
    public interface IPelanggaranState
    {
        void Next(PelanggaranContext context);
        string GetStatus();
    }
}
