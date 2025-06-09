using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PoinSiswa_Form.Model;

namespace PoinSiswa_Form.Automata
{
    /// <summary>
    /// Kelas PelanggaranStateMachine mengelola transisi antara status pelanggaran menggunakan state machine.
    /// </summary>
    public class PelanggaranStateMachine
    {
        // Record struct untuk mengenkapsulasi transisi dari PrevState ke NextState menggunakan Trigger.
        // Clean Code: Pemberian nama "Transisi" yang deskriptif untuk mewakili konsep transisi dalam state machine.
        private record struct Transisi(StatusPelanggaran PrevState, StatusPelanggaran NextState, Trigger Trigger);

        // Daftar transisi valid yang didefinisikan secara eksplisit.
        // Clean Code: Penggunaan collection initializer meningkatkan keterbacaan dan maintenance.
        private readonly List<Transisi> _transitions = new()
        {
            new(StatusPelanggaran.DILAPORKAN, StatusPelanggaran.DISETUJUI, Trigger.SETUJUI),
            new(StatusPelanggaran.DISETUJUI, StatusPelanggaran.DIBERI_SANKSI, Trigger.BERI_SANKSI),
            new(StatusPelanggaran.DIBERI_SANKSI, StatusPelanggaran.SELESAI, Trigger.SELESAIKAN)
        };

        // State saat ini disimpan di properti ini, dengan akses getter publik dan setter privat untuk menjaga enkapsulasi.
        public StatusPelanggaran CurrentState { get; private set; } = StatusPelanggaran.DILAPORKAN;

        /// <summary>
        /// Menentukan state berikutnya berdasarkan state sebelumnya (prevState) dan trigger yang diberikan.
        /// Melakukan validasi input untuk menjamin hanya nilai enum yang valid yang diproses.
        /// </summary>
        /// <param name="prevState">State sebelumnya dari pelanggaran</param>
        /// <param name="trigger">Trigger yang memicu transisi</param>
        /// <returns>State berikutnya</returns>
        public StatusPelanggaran GetNextState(StatusPelanggaran prevState, Trigger trigger)
        {
            // Secure Coding: Memvalidasi bahwa prevState adalah nilai yang didefinisikan dalam enum StatusPelanggaran.
            if (!Enum.IsDefined(typeof(StatusPelanggaran), prevState))
                throw new ArgumentException("State tidak valid.", nameof(prevState));

            // Secure Coding: Memvalidasi bahwa trigger adalah nilai yang didefinisikan dalam enum Trigger.
            if (!Enum.IsDefined(typeof(Trigger), trigger))
                throw new ArgumentException("Trigger tidak valid.", nameof(trigger));

            // Mencari transisi yang sesuai dengan kombinasi state dan trigger yang diberikan.
            foreach (var t in _transitions)
            {
                if (t.PrevState == prevState && t.Trigger == trigger)
                {
                    // Clean Code: Menggunakan Debug.Assert untuk memastikan NextState valid,
                    // membantu mendeteksi bug selama fase pengembangan.
                    Debug.Assert(Enum.IsDefined(typeof(StatusPelanggaran), t.NextState), "NextState harus valid.");
                    return t.NextState;
                }
            }

            // Jika tidak ditemukan transisi yang cocok, ambil daftar trigger valid untuk memberikan informasi lebih.
            var valid = GetValidTriggers(prevState);
            throw new InvalidOperationException(
                $"Transisi tidak tersedia dari {prevState} dengan {trigger}. Valid: {string.Join(", ", valid)}");
        }

        /// <summary>
        /// Mengaplikasikan trigger untuk mengubah CurrentState ke state berikutnya.
        /// </summary>
        /// <param name="trigger">Trigger yang akan diaktivasi</param>
        public void Activate(Trigger trigger)
        {
            // Clean Code: Mengotomatiskan transisi state dengan memanfaatkan metode GetNextState.
            CurrentState = GetNextState(CurrentState, trigger);

            // Debug.Assert memastikan bahwa state yang baru valid, mendukung secure coding.
            Debug.Assert(Enum.IsDefined(typeof(StatusPelanggaran), CurrentState), "State tidak valid setelah transisi.");
        }

        /// <summary>
        /// Mengembalikan daftar trigger yang valid untuk sebuah state tertentu.
        /// </summary>
        /// <param name="state">State yang ingin diketahui trigger validnya</param>
        /// <returns>IEnumerable trigger yang valid untuk state tertera</returns>
        public IEnumerable<Trigger> GetValidTriggers(StatusPelanggaran state)
        {
            // Secure Coding: Validasi bahwa state yang diterima adalah nilai yang valid.
            if (!Enum.IsDefined(typeof(StatusPelanggaran), state))
                throw new ArgumentException("State tidak valid.", nameof(state));

            // Clean Code: Penggunaan LINQ untuk menyaring dan mengambil trigger yang valid secara ringkas dan jelas.
            return _transitions
                .Where(t => t.PrevState == state)
                .Select(t => t.Trigger);
        }

        /// <summary>
        /// Mengaktivasi serangkaian trigger untuk mencapai target state yang diinginkan.
        /// Kode ini mereset state ke DILAPORKAN terlebih dahulu untuk konsistensi.
        /// </summary>
        /// <param name="targetState">State tujuan yang ingin dicapai</param>
        public void ActivateTo(StatusPelanggaran targetState)
        {
            // Secure Coding: Validasi bahwa targetState yang diminta valid.
            if (!Enum.IsDefined(typeof(StatusPelanggaran), targetState))
                throw new ArgumentException("Target state tidak valid.", nameof(targetState));

            // Reset ke state awal untuk memastikan urutan transisi berjalan konsisten.
            CurrentState = StatusPelanggaran.DILAPORKAN;
            if (targetState == CurrentState) return;

            // Clean Code: Menggunakan dictionary untuk mendefinisikan urutan transisi secara eksplisit.
            // Memetakan target state ke urutan trigger yang diperlukan untuk mencapai state tersebut.
            var path = new Dictionary<StatusPelanggaran, Trigger[]>
            {
                { StatusPelanggaran.DISETUJUI, new[] { Trigger.SETUJUI } },
                { StatusPelanggaran.DIBERI_SANKSI, new[] { Trigger.SETUJUI, Trigger.BERI_SANKSI } },
                { StatusPelanggaran.SELESAI, new[] { Trigger.SETUJUI, Trigger.BERI_SANKSI, Trigger.SELESAIKAN } },
            };

            // Jika tidak ada jalur transisi yang valid ke target state, lempar exception.
            if (!path.TryGetValue(targetState, out var triggers))
                throw new InvalidOperationException($"Tidak ada jalur transisi ke {targetState}.");

            // Melakukan transisi secara berurutan berdasarkan daftar trigger yang valid.
            foreach (var trigger in triggers)
            {
                Activate(trigger);
            }
        }
    }
}
