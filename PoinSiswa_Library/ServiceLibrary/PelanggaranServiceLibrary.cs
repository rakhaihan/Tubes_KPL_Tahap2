using System;
using System.Collections.Generic;
using Library.AutomataLibrary;
using Library.ModelLibrary;
using Library.TableDrivenLibrary;
using Library.ConfigurationLibrary;
using Library.ServiceLibrary;
using Tubes_Console.Library.ServiceLibrary;

namespace Library.ServiceLibrary
{
    /// <summary>
    /// Service untuk mengelola logika bisnis terkait pelanggaran siswa.
    /// </summary>
    public class PelanggaranService : IPelanggaranService
    {
        private readonly AppConfig _config;

        /// <summary>
        /// Konstruktor PelanggaranService dengan injeksi konfigurasi aplikasi.
        /// </summary>
        /// <param name="config">Konfigurasi batas poin dan notifikasi dari aplikasi.</param>
        public PelanggaranService(AppConfig config)
        {
            // === Secure Coding ===
            // Validasi bahwa konfigurasi tidak null
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Menambahkan pelanggaran baru ke siswa dan mengembalikan tindakan yang harus diambil.
        /// </summary>
        /// <param name="siswa">Siswa yang melakukan pelanggaran.</param>
        /// <param name="pelanggaran">Detail pelanggaran yang dilakukan.</param>
        /// <returns>Jenis tindakan (peringatan, panggilan orang tua, skorsing), atau null jika tidak ada.</returns>
        public string TambahPelanggaran(Siswa siswa, Pelanggaran pelanggaran)
        {
            // === Secure Coding ===
            // Validasi objek yang masuk tidak null
            if (siswa == null)
                throw new ArgumentNullException(nameof(siswa));

            if (pelanggaran == null)
                throw new ArgumentNullException(nameof(pelanggaran));

            if (string.IsNullOrWhiteSpace(pelanggaran.Jenis))
                throw new ArgumentException("Jenis pelanggaran tidak boleh kosong.", nameof(pelanggaran.Jenis));

            // Tambahkan pelanggaran ke riwayat siswa dan akumulasi poin
            siswa.RiwayatPelanggaran.Add(pelanggaran);
            siswa.TotalPoin += pelanggaran.Poin;

            // === Clean Code ===
            // Evaluasi total poin dan tentukan tindakan berdasarkan konfigurasi
            if (siswa.TotalPoin >= _config.BatasPoinSkorsing)
                return "Skorsing";

            if (siswa.TotalPoin >= _config.BatasPoinPanggilanOrangTua)
                return "Panggilan Orang Tua";

            if (siswa.TotalPoin >= _config.BatasPoinPeringatan)
                return "Peringatan Lisan";

            return null;
        }

        /// <summary>
        /// Mengubah status pelanggaran menggunakan state machine dan trigger yang valid.
        /// </summary>
        /// <param name="pelanggaran">Pelanggaran yang ingin diubah statusnya.</param>
        /// <param name="trigger">Trigger yang akan digunakan untuk transisi.</param>
        /// <returns>True jika status berhasil diubah, false jika tidak valid.</returns>
        public bool UbahStatusPelanggaran(Pelanggaran pelanggaran, Trigger trigger)
        {
            if (pelanggaran == null)
                throw new ArgumentNullException(nameof(pelanggaran));

            // Inisialisasi state machine berdasarkan status saat ini
            var sm = new PelanggaranStateMachine(pelanggaran.Status);

            try
            {
                sm.Activate(trigger);
            }
            catch (InvalidOperationException)
            {
                // Jika transisi tidak valid, kembalikan false
                return false;
            }

            // Jika state berhasil berubah, simpan state baru ke objek pelanggaran
            if (sm.CurrentState != pelanggaran.Status)
            {
                pelanggaran.Status = sm.CurrentState;
                return true;
            }

            return false;
        }
    }

}
