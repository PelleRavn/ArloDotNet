using System;
using System.Threading.Tasks;
using Arlo;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new TestApplication();
            application.Run().ContinueWith(t =>
            {
                if (t.IsFaulted == true)
                {
                    System.Diagnostics.Debug.WriteLine(t.Exception);
                }
            });

            Console.ReadKey();
        }
    }
}
