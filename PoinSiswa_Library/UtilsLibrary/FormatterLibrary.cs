using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.UtilsLibrary
{
    /// <summary>
    /// Utilitas untuk formatting data.
    /// </summary>
    public static class Formatter
    {
        /// <summary>
        /// Memformat tanggal ke dalam format 'dd MMM yyyy' (contoh: 07 Jun 2025).
        /// </summary>
        /// <param name="tanggal">Tanggal yang ingin diformat.</param>
        /// <returns>String tanggal dalam format yang mudah dibaca.</returns>
        public static string FormatTanggal(DateTime tanggal)
        {
            return tanggal.ToString("dd MMM yyyy");
        }
    }

}
