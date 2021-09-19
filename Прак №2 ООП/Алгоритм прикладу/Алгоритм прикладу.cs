using System;

namespace Алгоритму_Прикладу
{
    class Program
    {
        static void Main(string[] args)
        {
            string xString = Console.ReadLine();
            int x = Convert.ToInt32(xString);
            int y = x * x;
            Console.WriteLine($"x^2={y}");
            double z = Math.Cos(y);
            Console.WriteLine($"cos(x^2={z}");
            Console.ReadKey();

        }
    }
}
