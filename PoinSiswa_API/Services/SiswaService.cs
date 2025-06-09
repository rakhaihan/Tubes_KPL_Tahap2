using System.Collections.Generic;
using System.Linq;
using PoinSiswa_API.Models;

namespace PoinSiswa_API.Services
{
    // Layanan untuk mengelola data siswa
    public class SiswaService
    {
        private static readonly List<Siswa> siswaList = new();

        // Mengambil semua siswa
        public List<Siswa> GetAll() => siswaList;

        // Mengambil siswa berdasarkan ID
        public Siswa? GetById(int id) =>
            siswaList.FirstOrDefault(s => s.Id == id);

        // Menambahkan siswa baru
        public void Add(Siswa siswa)
        {
            if (siswa == null)
                throw new System.ArgumentNullException(nameof(siswa));

            siswaList.Add(siswa);
        }

        // Memperbarui data siswa berdasarkan ID
        public void Update(int id, Siswa updated)
        {
            if (updated == null)
                throw new System.ArgumentNullException(nameof(updated));

            var siswa = GetById(id);
            if (siswa != null)
            {
                siswa.Nama = updated.Nama;
                siswa.Kelas = updated.Kelas;
                siswa.TotalPoin = updated.TotalPoin;
                siswa.RiwayatPelanggaran = updated.RiwayatPelanggaran ?? new List<PoinPelanggaran>();
            }
        }

        // Menghapus siswa berdasarkan ID
        public void Delete(int id)
        {
            var siswa = GetById(id);
            if (siswa != null)
                siswaList.Remove(siswa);
        }

        // Menambahkan pelanggaran ke siswa
        public void TambahPelanggaran(int siswaId, PoinPelanggaran pelanggaran)
        {
            if (pelanggaran == null)
                throw new System.ArgumentNullException(nameof(pelanggaran));

            var siswa = GetById(siswaId);
            if (siswa != null)
            {
                siswa.RiwayatPelanggaran ??= new List<PoinPelanggaran>();
                siswa.RiwayatPelanggaran.Add(pelanggaran);
                siswa.TotalPoin += pelanggaran.Poin;
            }
        }
    }
}
