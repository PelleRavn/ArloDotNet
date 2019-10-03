using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var arlo = new Arlo.Arlo();
            Arlo.Arlo.Email = "";
            Arlo.Arlo.Password = "";
            arlo.Authenticate().ContinueWith(t =>
            {

            });

            Console.ReadKey();
        }
    }
}
