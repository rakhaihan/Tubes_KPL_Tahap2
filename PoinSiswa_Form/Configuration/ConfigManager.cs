using System;
using System.IO;
using System.Text.Json;

namespace Tubes_Console.Configuration
{

    public class ConfigManager
    {
        /// Objek konfigurasi utama.
        public AppConfig Config { get; private set; }

        private const string ConfigFilePath = "AppConfig.json";

        
        /// Inisialisasi dan memuat konfigurasi dari file atau membuat default jika gagal.
    
        public ConfigManager()
        {
            if (!TryReadConfigFile())
            {
                Console.Error.WriteLine("⚠️ Gagal memuat konfigurasi. Menggunakan konfigurasi default.");
                SetDefaultConfig();
                SaveConfigToFile();
            }
        }

        /// Mencoba membaca file konfigurasi dan melakukan deserialisasi.
        /// <returns>True jika berhasil membaca dan mendeserialisasi, false jika gagal.</returns>
        private bool TryReadConfigFile()
        {
            try
            {
                if (!File.Exists(ConfigFilePath))
                    return false;

                string jsonData = File.ReadAllText(ConfigFilePath);
                var config = JsonSerializer.Deserialize<AppConfig>(jsonData);

                if (config == null)
                    throw new InvalidDataException("File konfigurasi tidak valid atau kosong.");

                Config = config;
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"❌ Kesalahan saat membaca file konfigurasi: {ex.Message}");
                return false;
            }
        }

       
        /// Menyimpan konfigurasi saat ini ke file JSON.
        
        public void SaveConfigToFile()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(Config, options);
                File.WriteAllText(ConfigFilePath, json);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"❌ Gagal menyimpan file konfigurasi: {ex.Message}");
            }
        }

        
        /// Mengatur nilai konfigurasi default.
        
        private void SetDefaultConfig()
        {
            Config = new AppConfig(10, 20, 30, notifEmail: true, notifWa: false, defaultRole: "Siswa");
        }
    }
}
