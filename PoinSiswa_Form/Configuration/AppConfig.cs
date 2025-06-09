using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Console.Configuration
{

    public class AppConfig
    {

        /// Batas poin untuk peringatan pertama kepada siswa.
        public int BatasPoinPeringatan { get; private set; }


        /// Batas poin untuk pemanggilan orang tua siswa.

        public int BatasPoinPanggilanOrangTua { get; private set; }


        /// Batas poin untuk skorsing siswa.

        public int BatasPoinSkorsing { get; private set; }


        /// Menentukan apakah notifikasi email diaktifkan.

        public bool IsNotifikasiEmailAktif { get; private set; }


        /// Menentukan apakah notifikasi WhatsApp diaktifkan.

        public bool IsNotifikasiWhatsappAktif { get; private set; }


        /// Peran default untuk pengguna baru.

        public string DefaultRoleUserBaru { get; private set; }


        /// Konstruktor parameterless untuk deserialisasi atau inisialisasi default.

        public AppConfig() { }

        /// Konstruktor dengan parameter lengkap dan validasi dasar.

        /// <param name="batasPoinPeringatan">Batas poin untuk peringatan.
        /// <param name="batasPoinPanggilanOrangTua">Batas poin untuk pemanggilan orang tua.</param>
        /// <param name="batasPoinSkorsing">Batas poin untuk skorsing.</param>
        /// <param name="notifEmail">Status aktivasi notifikasi email.</param>
        /// <param name="notifWa">Status aktivasi notifikasi WhatsApp.</param>
        /// <param name="defaultRole">Peran default pengguna baru.</param>
        /// <exception cref="ArgumentException">Jika nilai batas poin negatif atau role kosong.</exception>
        public AppConfig(int batasPoinPeringatan, int batasPoinPanggilanOrangTua, int batasPoinSkorsing,
                         bool notifEmail, bool notifWa, string defaultRole)
        {
            if (batasPoinPeringatan < 0 || batasPoinPanggilanOrangTua < 0 || batasPoinSkorsing < 0)
                throw new ArgumentException("Batas poin tidak boleh bernilai negatif.");

            if (string.IsNullOrWhiteSpace(defaultRole))
                throw new ArgumentException("Role default tidak boleh kosong.");

            BatasPoinPeringatan = batasPoinPeringatan;
            BatasPoinPanggilanOrangTua = batasPoinPanggilanOrangTua;
            BatasPoinSkorsing = batasPoinSkorsing;
            IsNotifikasiEmailAktif = notifEmail;
            IsNotifikasiWhatsappAktif = notifWa;
            DefaultRoleUserBaru = defaultRole;
        }
    }
}

