using System;

namespace Неявні_перетворення
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 100;
            short s = b;
            int x = s;
            long y = x;
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
