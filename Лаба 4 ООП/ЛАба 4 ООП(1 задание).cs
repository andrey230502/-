using System;

namespace laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            double min;
            double max;
        m1: Console.WriteLine("Значення X");
            double x = double.Parse((Console.ReadLine()));
            Console.WriteLine("Значення Y");
            double y = double.Parse((Console.ReadLine()));
            Console.WriteLine("Значення Z");
            double z = double.Parse((Console.ReadLine()));
            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }
            if (x + y > z)
            {
                min = x;
            }
            else
            {
                min = (x + y);
            }
            double c = max + Math.Abs(x + z);
            if (c == 0)
            {
                Console.WriteLine("Знаменик дорівнює 0,щоб вести значення по новому натисніть будь-яку клавішу" + '\n' + "По закінченню програми натисніть Enter.");
                string j = Console.ReadLine();
                if (j != "") goto m1;
                goto m1;
            }
            else
            {
                f = min / max + Math.Abs(x + z);
            }
            Console.WriteLine('\n' + "Дано:X=" + x + "Y=" + y + "Z=" + z + '\n' + ")Результат:F=" + f);
            Console.WriteLine('\n' + "ДЛя повторного ввода" + "набрати будь-яку клавішу." + '\n' + "Для завершення програминатисніть Enter.");
            string p = Console.ReadLine();
            if (p != "") goto m1;




            }
    }
}
