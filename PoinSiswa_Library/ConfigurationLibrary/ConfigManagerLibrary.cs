using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace Library.ConfigurationLibrary
{
    /// <summary>
    /// Mengelola konfigurasi aplikasi dari dan ke file JSON.
    /// </summary>
    public class ConfigManager
    {
        public AppConfig Config { get; private set; }
        private readonly string _configFilePath;

        /// <summary>
        /// Membaca konfigurasi dari file, atau membuat default jika file tidak valid.
        /// </summary>
        /// <param name="configFilePath">Path ke file konfigurasi JSON.</param>
        public ConfigManager(string configFilePath = "AppConfig.json")
        {
            _configFilePath = configFilePath ?? throw new ArgumentNullException(nameof(configFilePath));

            try
            {
                ReadConfigFile();
            }
            catch (Exception ex)
            {
                // Jika gagal membaca, buat konfigurasi default dan simpan ke file
                Console.Error.WriteLine($"Gagal membaca file konfigurasi: {ex.Message}");
                SetDefault();
                WriteConfigFile();
            }
        }

        /// <summary>
        /// Membaca file konfigurasi dan deserialisasi ke dalam objek AppConfig.
        /// </summary>
        private void ReadConfigFile()
        {
            string jsonData = File.ReadAllText(_configFilePath);
            Config = JsonSerializer.Deserialize<AppConfig>(jsonData) ?? throw new InvalidOperationException("Data konfigurasi tidak valid atau kosong.");
        }

        /// <summary>
        /// Menulis konfigurasi saat ini ke file JSON.
        /// </summary>
        private void WriteConfigFile()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(Config, options);
            File.WriteAllText(_configFilePath, json);
        }

        /// <summary>
        /// Menetapkan konfigurasi default jika file tidak ditemukan atau rusak.
        /// </summary>
        private void SetDefault()
        {
            Config = new AppConfig(
                batasPoinPeringatan: 10,
                batasPoinPanggilanOrangTua: 20,
                batasPoinSkorsing: 30,
                notifEmail: true,
                notifWa: false,
                defaultRole: "Siswa"
            );
        }
    }

}
