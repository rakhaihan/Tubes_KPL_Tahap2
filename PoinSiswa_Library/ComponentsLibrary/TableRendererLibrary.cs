using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ComponentsLibrary
{
    /// <summary>
    /// Komponen untuk merender list data ke dalam format tabel teks.
    /// </summary>
    public static class TableRenderer
    {
        /// <summary>
        /// Merender data ke dalam string tabel berdasarkan kolom dan selector.
        /// </summary>
        /// <typeparam name="T">Tipe data objek.</typeparam>
        /// <param name="data">List data yang akan dirender.</param>
        /// <param name="columns">Dictionary label kolom dan selector nilai.</param>
        /// <returns>String tabel yang terformat.</returns>
        public static string Render<T>(List<T> data, Dictionary<string, Func<T, string>> columns)
        {
            // === Secure Coding ===
            // Pastikan data dan kolom tidak null
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            if (columns == null)
                throw new ArgumentNullException(nameof(columns));

            var builder = new StringBuilder();

            // Tampilkan header tabel
            builder.AppendLine(string.Join(" | ", columns.Keys));

            // Render tiap baris dari data
            foreach (var item in data)
            {
                var row = columns.Values.Select(selector => selector(item));
                builder.AppendLine(string.Join(" | ", row));
            }

            return builder.ToString();
        }
    }

}

