using System;
using System.IO;
using System.Linq;
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

            if (string.IsNullOrEmpty(config?.Token) == true)
            {
                Console.WriteLine("Logging in...");
                var loginResult = await ArloClient.AuthenticateAsync(config.Email, config.Password);

                if (loginResult.Success)
                {
                    Console.WriteLine("Login successful");

                    config.UserId = loginResult.Data.UserId;
                    config.Token = loginResult.Data.Token;

                    SaveConfig(config);
                }
                else
                {
                    Console.WriteLine($"Login failed! {loginResult.ErrorData.Error}: {loginResult.ErrorData.Message}");
                }
            }

            var arlo = new ArloClient(config?.Token, config?.UserId);

            var devices = await arlo.GetDevicesAsync();
            if (devices.Success)
            {
                Console.WriteLine($"Devices: {devices.Data.Count}");

                var firstCamera = devices.Data.FirstOrDefault(f => f.DeviceType.Equals("camera"));
                var baseStation = devices.Data.FirstOrDefault(f => f.DeviceId.Equals(firstCamera.ParentId));

                var armResult = await arlo.ArmDeviceAsync(baseStation);
                if (armResult.Success)
                {
                    Console.WriteLine($"Did arm device: {baseStation.DeviceName} ({baseStation.DeviceId})");

                }
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