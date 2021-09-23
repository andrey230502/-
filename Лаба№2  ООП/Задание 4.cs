using System;

namespace задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("The current date and time is" + System.DateTime.Now);
            Console.WriteLine("Input x + |r");
            double x = Convert.ToDouble(Console.ReadLine());
            double J = Math.Exp(4 * x / 5) + Math.Sin(7 * Math.Log(x + 5 / 3)) + x / 5;
            Console.WriteLine("x+{0}\t J = {1}", x, J);
            Console.ReadKey();
        }
    }
}
