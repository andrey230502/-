using System;

namespace Логічний_тип
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b1 = true, b2 = false, b3 = b1, b4 = !b2;//BAD CODE
            bool ba = true;
            bool bb = false;
            bool bc = ba;
            bool bd = !bb;
            Console.WriteLine($"ba={ba}\nbb={bb}\nbc={bc}\nbd={bd}");
            Console.ReadKey();
        }
    }
}
