using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ComponentsLibrary
{
    /// <summary>
    /// Komponen pembangun formulir teks dari objek generik.
    /// </summary>
    public static class FormBuilder
    {
        /// <summary>
        /// Menghasilkan string form berdasarkan field dan data dari objek.
        /// </summary>
        /// <typeparam name="T">Tipe data objek yang digunakan.</typeparam>
        /// <param name="fieldGenerators">Dictionary berisi label dan fungsi pengambil nilai dari objek.</param>
        /// <param name="data">Objek data sumber nilai.</param>
        /// <returns>String hasil form yang terformat.</returns>
        public static string GenerateForm<T>(Dictionary<string, Func<T, string>> fieldGenerators, T data)
        {
            // === Secure Coding ===
            // Validasi bahwa parameter tidak null
            if (fieldGenerators == null)
                throw new ArgumentNullException(nameof(fieldGenerators));

            if (data == null)
                throw new ArgumentNullException(nameof(data));

            // === Clean Code ===
            // Gunakan StringBuilder untuk efisiensi memori
            var builder = new StringBuilder();

            foreach (var field in fieldGenerators)
            {
                string label = field.Key;
                string value = field.Value?.Invoke(data) ?? "[null]";
                builder.AppendLine($"{label}: {value}");
            }

            return builder.ToString();
        }
    }

}

