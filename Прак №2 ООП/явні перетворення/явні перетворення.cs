using System;

namespace Явні_перетворення
{
    class Program
    {
        static void Main(string[] args)
        {
            long l = 2_000_000_000_002L;
            int i = (int)l;
            short s = (short)i;
            byte b = (byte)s;
            Console.WriteLine($"l={l}\ni={i}\ns={s}\nb={b}");
            Console.ReadKey();


        }
    }
}
