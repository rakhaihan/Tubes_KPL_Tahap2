using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;
using PoinSiswa_API.States;

namespace API.Services
{
    public class PoinPelanggaranService
    {
        private static List<PoinPelanggaran> data = new List<PoinPelanggaran>();
        private static int nextId = 1;

        public List<PoinPelanggaran> GetAll() => data.OrderByDescending(p => p.Tanggal).ToList();

        public List<PoinPelanggaran> GetBySiswaId(int siswaId) =>
            data.Where(p => p.SiswaId == siswaId).ToList();

        public PoinPelanggaran GetById(int id) =>
            data.FirstOrDefault(p => p.Id == id);

        public void Add(PoinPelanggaran poin)
        {
            poin.Id = nextId++;
            poin.Tanggal = poin.Tanggal == default ? DateTime.Now : poin.Tanggal;
            data.Add(poin);
        }

        public bool UpdateStatus(int id, StatusPelanggaran status)
        {
            var poin = GetById(id);
            if (poin == null) return false;

            poin.Status = status;

            var context = new PoinPelanggaranContext();

            PoinPelanggaranState state = status switch
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


        public bool Delete(int id)
        {
            var poin = GetById(id);
            if (poin == null) return false;
            data.Remove(poin);
            return true;
        }

        public int GetTotalPoinDisetujuiBySiswa(int siswaId)
        {
            return data
                .Where(p => p.SiswaId == siswaId && p.Status == StatusPelanggaran.Disetujui)
                .Sum(p => p.Poin);
        }
    }
}
