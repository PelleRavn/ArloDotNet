using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Arlo;
using TestConsole.Models;

namespace TestConsole
{
    public class TestApplication
    {
        public TestApplication()
        {
        }

        public async Task Run()
        {
            var config = GetConfig();

            var loginToken = config?.Token;
            if (string.IsNullOrEmpty(loginToken) == true)
            {
                Console.WriteLine("Logging in...");
                var loginResult = await ArloClient.AuthenticateAsync(config.Email, config.Password);

                if (loginResult.Success)
                {
                    Console.WriteLine("Login successful");
                    loginToken = loginResult.Data.Token;

                    config.Token = loginToken;
                    SaveConfig(config);
                }
                else
                {
                    Console.WriteLine($"Login failed! {loginResult.ErrorData.Error}: {loginResult.ErrorData.Message}");
                }
            }

            var arlo = new ArloClient(loginToken);

            var devices = await arlo.GetDevicesAsync();
            if (devices.Success)
            {
                Console.WriteLine($"Devices: {devices.Data.Count}");
            }
            else
            {
                Console.WriteLine($"Error getting devices! {devices.ErrorData.Error}: {devices.ErrorData.Message}");
            }

            var dateFrom = new DateTime(2019, 10, 1);
            var dateTo = new DateTime(2019, 10, 30);

            var media = await arlo.GetLibraryAsync(dateFrom, dateTo);
            if (media.Success)
            {
                Console.WriteLine($"Media: {media.Data.Count}");
            }
            else
            {
                Console.WriteLine($"Error getting devices! {media.ErrorData.Error}: {media.ErrorData.Message}");
            }
        }

        private Config GetConfig()
        {
            using (StreamReader r = new StreamReader("config.json"))
            {
                string json = r.ReadToEnd();
                var config = JsonSerializer.Deserialize<Config>(json);
                if (config == null)
                {
                    config = new Config();
                }
                return config;
            }
        }

        private void SaveConfig(Config config)
        {
            var json = JsonSerializer.Serialize(config);
            File.WriteAllText("config.json", json);
        }
    }
}