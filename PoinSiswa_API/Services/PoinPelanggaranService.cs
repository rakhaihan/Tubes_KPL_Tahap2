using System;
using System.Collections.Generic;
using System.Linq;
using PoinSiswa_API.Models;
using PoinSiswa_API.States;

namespace PoinSiswa_API.Services
{
    // Layanan untuk mengelola data poin pelanggaran
    public class PoinPelanggaranService
    {
        private static readonly List<PoinPelanggaran> data = new();
        private static int nextId = 1;

        // Mengambil semua data pelanggaran, diurutkan dari terbaru
        public List<PoinPelanggaran> GetAll() =>
            data.OrderByDescending(p => p.Tanggal).ToList();

        // Mengambil data pelanggaran berdasarkan ID siswa
        public List<PoinPelanggaran> GetBySiswaId(int siswaId) =>
            data.Where(p => p.SiswaId == siswaId).ToList();

        // Mengambil satu pelanggaran berdasarkan ID
        public PoinPelanggaran? GetById(int id) =>
            data.FirstOrDefault(p => p.Id == id);

        // Menambahkan pelanggaran baru
        public void Add(PoinPelanggaran poin)
        {
            if (poin == null)
                throw new ArgumentNullException(nameof(poin));

            poin.Id = nextId++;
            poin.Tanggal = poin.Tanggal == default ? DateTime.Now : poin.Tanggal;
            data.Add(poin);
        }

        // Memperbarui status pelanggaran berdasarkan ID
        public bool UpdateStatus(int id, StatusPelanggaran status)
        {
            var poin = GetById(id);
            if (poin == null) return false;

            poin.Status = status;

            var context = new PoinPelanggaranContext();

            IPoinPelanggaranState state = status switch
            {
                StatusPelanggaran.Menunggu => new MenungguState(),
                StatusPelanggaran.Disetujui => new DisetujuiState(),
                StatusPelanggaran.Ditolak => new DitolakState(),
                _ => throw new ArgumentOutOfRangeException(nameof(status), "Status tidak dikenal")
            };

            context.SetState(state);
            context.ApplyState(poin);

            return true;
        }

        // Menghapus pelanggaran berdasarkan ID
        public bool Delete(int id)
        {
            var poin = GetById(id);
            if (poin == null) return false;

            data.Remove(poin);
            return true;
        }

        // Menghitung total poin yang disetujui berdasarkan siswa
        public int GetTotalPoinDisetujuiBySiswa(int siswaId)
        {
            return data
                .Where(p => p.SiswaId == siswaId && p.Status == StatusPelanggaran.Disetujui)
                .Sum(p => p.Poin);
        }
    }
}
