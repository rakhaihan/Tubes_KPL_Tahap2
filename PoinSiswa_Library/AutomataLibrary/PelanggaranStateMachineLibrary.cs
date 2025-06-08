using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.ModelLibrary;

namespace Library.AutomataLibrary
{
    /// <summary>
    /// State machine untuk mengelola transisi status pelanggaran.
    /// </summary>
    public class PelanggaranStateMachine
    {
        private readonly struct Transisi
        {
            public StatusPelanggaran PrevState { get; }
            public StatusPelanggaran NextState { get; }
            public Trigger Trigger { get; }

            public Transisi(StatusPelanggaran prevState, StatusPelanggaran nextState, Trigger trigger)
            {
                // === Secure Coding ===
                // Validasi bahwa nilai-nilai yang diberikan adalah anggota sah dari enum
                if (!Enum.IsDefined(typeof(StatusPelanggaran), prevState) ||
                    !Enum.IsDefined(typeof(StatusPelanggaran), nextState) ||
                    !Enum.IsDefined(typeof(Trigger), trigger))
                    throw new ArgumentException("Nilai status atau trigger tidak valid.");

                PrevState = prevState;
                NextState = nextState;
                Trigger = trigger;
            }
        }

        private readonly List<Transisi> _transitions = new List<Transisi>
            {
                new Transisi(StatusPelanggaran.MENUNGGU, StatusPelanggaran.DILAPORKAN, Trigger.SETUJUI),
                new Transisi(StatusPelanggaran.DILAPORKAN, StatusPelanggaran.DISETUJUI, Trigger.SETUJUI),
                new Transisi(StatusPelanggaran.DISETUJUI, StatusPelanggaran.DIBERI_SANKSI, Trigger.BERI_SANKSI),
                new Transisi(StatusPelanggaran.DIBERI_SANKSI, StatusPelanggaran.SELESAI, Trigger.SELESAIKAN)
            };

        public StatusPelanggaran CurrentState { get; private set; }

        public PelanggaranStateMachine(StatusPelanggaran initialState)
        {
            if (!Enum.IsDefined(typeof(StatusPelanggaran), initialState))
                throw new ArgumentException("Status awal tidak valid.", nameof(initialState));

            CurrentState = initialState;
        }

        /// <summary>
        /// Mengambil daftar trigger yang valid untuk sebuah state tertentu.
        /// </summary>
        /// <param name="state">State yang ingin diketahui trigger valid-nya.</param>
        /// <returns>List trigger yang valid untuk state tersebut.</returns>
        public IEnumerable<Trigger> GetValidTriggers(StatusPelanggaran state)
        {
            // === Secure Coding ===
            // Validasi bahwa state yang diberikan adalah nilai yang sah dari enum
            if (!Enum.IsDefined(typeof(StatusPelanggaran), state))
                throw new ArgumentException("State tidak valid.", nameof(state));

            // === Clean Code ===
            // Menyaring daftar transisi untuk menemukan trigger yang sesuai dengan state awal
            return _transitions
                .Where(t => t.PrevState == state)
                .Select(t => t.Trigger);
        }

        /// <summary>
        /// Mengaktifkan serangkaian trigger untuk mencapai target state yang diinginkan.
        /// </summary>
        /// <param name="targetState">State tujuan yang ingin dicapai.</param>
        public void ActivateTo(StatusPelanggaran targetState)
        {
            // === Secure Coding ===
            // Validasi bahwa targetState adalah anggota yang valid dari enum
            if (!Enum.IsDefined(typeof(StatusPelanggaran), targetState))
                throw new ArgumentException("Target state tidak valid.", nameof(targetState));

            if (CurrentState == targetState) return;

            // Reset ke state awal agar transisi dapat dilakukan dari awal secara konsisten
            CurrentState = StatusPelanggaran.DILAPORKAN;

            // Replace the target-typed object creation with explicit type instantiation
            var path = new Dictionary<StatusPelanggaran, List<Trigger>>
            {
                [StatusPelanggaran.DISETUJUI] = new List<Trigger> { Trigger.SETUJUI },
                [StatusPelanggaran.DIBERI_SANKSI] = new List<Trigger> { Trigger.SETUJUI, Trigger.BERI_SANKSI },
                [StatusPelanggaran.SELESAI] = new List<Trigger> { Trigger.SETUJUI, Trigger.BERI_SANKSI, Trigger.SELESAIKAN }
            };

            // === Secure Coding ===
            // Jika target state tidak ditemukan dalam path, berarti tidak ada rute yang sah
            if (!path.TryGetValue(targetState, out var triggers))
                throw new InvalidOperationException($"Tidak ada jalur transisi ke state: {targetState}");

            // Jalankan semua trigger untuk mencapai target state
            foreach (var trigger in triggers)
            {
                Activate(trigger);
            }
        }

        /// <summary>
        /// Melakukan transisi status berdasarkan trigger yang diberikan.
        /// </summary>
        /// <param name="trigger">Trigger untuk memicu transisi.</param>
        public void Activate(Trigger trigger)
        {
            // Mengatur state ke next state berdasarkan current state dan trigger
            CurrentState = GetNextState(CurrentState, trigger);
        }

        /// <summary>
        /// Mengambil next state berdasarkan current state dan trigger.
        /// </summary>
        /// <param name="prevState">State saat ini.</param>
        /// <param name="trigger">Trigger yang diberikan.</param>
        /// <returns>State tujuan jika transisi sah.</returns>
        private StatusPelanggaran GetNextState(StatusPelanggaran prevState, Trigger trigger)
        {
            if (!Enum.IsDefined(typeof(StatusPelanggaran), prevState) ||
                !Enum.IsDefined(typeof(Trigger), trigger))
                throw new ArgumentException("PrevState atau trigger tidak valid.");

            var transition = _transitions.FirstOrDefault(t => t.PrevState == prevState && t.Trigger == trigger);

            if (transition.Equals(default(Transisi)))
                throw new InvalidOperationException($"Tidak ada transisi dari {prevState} dengan trigger {trigger}");

            return transition.NextState;
        }
    }

}