using Library.ModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_Console.Library.ServiceLibrary;

namespace Library.ServiceLibrary
{
    /// <summary>
    /// Service untuk mengelola data siswa secara in-memory.
    /// </summary>
    public class SiswaService : ISiswaService
    {
        private readonly List<Siswa> _daftarSiswa = new List<Siswa>();

        /// <summary>
        /// Menambahkan data siswa baru ke daftar siswa.
        /// </summary>
        /// <param name="siswa">Objek siswa yang akan ditambahkan.</param>
        public void TambahSiswa(Siswa siswa)
        {
            if (siswa == null)
                throw new ArgumentNullException(nameof(siswa));

            if (string.IsNullOrWhiteSpace(siswa.Nama))
                throw new ArgumentException("Nama siswa tidak boleh kosong.", nameof(siswa.Nama));

            if (string.IsNullOrWhiteSpace(siswa.Kelas))
                throw new ArgumentException("Kelas siswa tidak boleh kosong.", nameof(siswa.Kelas));

            _daftarSiswa.Add(siswa);
        }

        /// <summary>
        /// Mencari siswa berdasarkan ID.
        /// </summary>
        /// <param name="id">ID unik siswa.</param>
        /// <returns>Objek siswa jika ditemukan, null jika tidak.</returns>
        public Siswa CariSiswa(int id)
        {
            if (id <= 0)
                return null;

            return _daftarSiswa.FirstOrDefault(s => s.Id == id);
        }

        /// <summary>
        /// Mengambil semua data siswa yang terdaftar.
        /// </summary>
        /// <returns>List semua siswa.</returns>
        public List<Siswa> GetSemua()
        {
            return new List<Siswa>(_daftarSiswa);
        }

        /// <summary>
        /// Memperbarui data siswa berdasarkan ID.
        /// </summary>
        /// <param name="id">ID siswa yang ingin diperbarui.</param>
        /// <param name="updatedSiswa">Objek siswa baru sebagai pembaruan.</param>
        public void UpdateSiswa(int id, Siswa updatedSiswa)
        {
            if (updatedSiswa == null)
                throw new ArgumentNullException(nameof(updatedSiswa));

            if (string.IsNullOrWhiteSpace(updatedSiswa.Nama))
                throw new ArgumentException("Nama siswa tidak boleh kosong.", nameof(updatedSiswa.Nama));

            if (string.IsNullOrWhiteSpace(updatedSiswa.Kelas))
                throw new ArgumentException("Kelas siswa tidak boleh kosong.", nameof(updatedSiswa.Kelas));

            var siswa = CariSiswa(id);
            if (siswa != null)
            {
                siswa.Nama = updatedSiswa.Nama;
                siswa.Kelas = updatedSiswa.Kelas;
                siswa.TotalPoin = updatedSiswa.TotalPoin;
                siswa.RiwayatPelanggaran = updatedSiswa.RiwayatPelanggaran ?? new List<Pelanggaran>();
            }
        }

        /// <summary>
        /// Menghapus siswa berdasarkan ID.
        /// </summary>
        /// <param name="id">ID siswa yang akan dihapus.</param>
        /// <returns>True jika berhasil dihapus, false jika siswa tidak ditemukan.</returns>
        public bool HapusSiswa(int id)
        {
            var siswa = CariSiswa(id);
            if (siswa == null)
                return false;

            return _daftarSiswa.Remove(siswa);
        }
    }

}
