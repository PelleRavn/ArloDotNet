using System;
using Arlo;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Arlo.Arlo.Email = "";
            Arlo.Arlo.Password = "";
            var arlo = new ArloClient();
            arlo.Authenticate().ContinueWith(t =>
            {
                if (t.IsFaulted == false)
                {
                    var devices = arlo.GetDevicesAsync();
                    var media = arlo.GetLibraryAsync();
                }
            });

            Console.ReadKey();
        }
    }
}
