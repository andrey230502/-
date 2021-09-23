using System;

namespace Лаба___2задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // вивести версіо о. с.
            OperatingSystem os = System.Environment.OSVersion;
            Console.WriteLine("Platform: {0}", os.Platform);
            System.Console.WriteLine("The current date and time is" + System.DateTime.Now);  // Дата і час
            System.Console.ReadLine();

        }
    }
}
