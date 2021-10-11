using System;

namespace laba4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
        m1: Console.WriteLine("Точка M по " + "X=");
            float x = float.Parse((Console.ReadLine()));
            Console.WriteLine("Точка M по " + "Y=");
            float y = float.Parse((Console.ReadLine()));
            if (y > 0)
            {
                if (Math.Pow(x, 3) / y > 3) 
                {
                    if (x >= 0) N = 2;
                    else N = 1;
                }
                else
                {
                    if (x >= 0) N = 4;
                    else N = 2;
                }
            }
            else
            {
                if (x >= 0) N = 4;
                else N = 3;
            }
            Console.WriteLine('\t' + "Виходить:");
            Console.WriteLine("M(" + x + ";" + y + ")" + " В області N=" + N);
            Console.WriteLine('\n' + "Повторний ввод" + "Нажати любу клавішу" + '\n' + "Для завершення Enter");
            string p = Console.ReadLine();
            if (p != "") goto m1;
        }
    }
}
