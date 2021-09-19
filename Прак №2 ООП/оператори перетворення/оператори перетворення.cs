using System;

namespace Оперативні_перетворення
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int x1 = int.Parse(x);
            int x2 = Convert.ToInt32(x);
            Console.WriteLine($"x^2={x1 * x2}");
            Console.ReadKey();

        }
    }
}
