using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.ModelLibrary;

namespace Library.ServiceLibrary
{
    /// <summary>
    /// Service untuk mengirimkan notifikasi kepada pengguna.
    /// </summary>
    public class NotifikasiService : INotifikasiService
    {
        /// <summary>
        /// Event yang akan dipicu saat notifikasi dikirim.
        /// </summary>
        public event Action<string, Pengguna> OnNotifikasi;

        /// <summary>
        /// Mengirim notifikasi kepada pengguna tertentu.
        /// </summary>
        /// <param name="pesan">Pesan notifikasi.</param>
        /// <param name="penerima">Objek pengguna yang menerima notifikasi.</param>
        public void KirimNotifikasi(string pesan, Pengguna penerima)
        {
            // === Secure Coding ===
            // Validasi input
            if (string.IsNullOrWhiteSpace(pesan))
                throw new ArgumentException("Pesan tidak boleh kosong.", nameof(pesan));

            if (penerima == null)
                throw new ArgumentNullException(nameof(penerima));

            // Format notifikasi dan kirim melalui event handler
            string notifikasi = $"[NOTIFIKASI] Kepada {penerima.Username}: {pesan}";
            OnNotifikasi?.Invoke(notifikasi, penerima);
        }
    }


}
