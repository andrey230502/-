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
            double J = Math.Exp(4d * x / 5d) + Math.Sin(7d * Math.Log(x + 5d / 3d)) + x / 5d;
            Console.WriteLine("x+{0}\t J = {1}", x, J);
            Console.ReadKey();
        }
    }
}
