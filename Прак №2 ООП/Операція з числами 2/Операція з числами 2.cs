using System;

namespace Операції_з_числами_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1_003;
            Console.WriteLine($"a/10={a / 10}");//NOT 100,3
            Console.WriteLine($"a%100={a % 10}");
            Console.ReadKey();

        }
    }
}
