using System;

namespace Лаба_5__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, S, a, c, v, b, n;
            int k;
        m1: Console.WriteLine("Ввести значення x");
            x = double.Parse((Console.ReadLine()));
            Console.WriteLine('\t' + "Промежуточные результаты" + '\n');
            k = 0;
            S = 1; c = 1;
            v = 0;
            a = x;
            while (Math.Abs(a) >= 0.000001)
            {
                S += a;
                b = x * c;
                n = b;
                c += 2;
                v = x * x;
                a = 2 * (b / n);
                k++;
                Console.WriteLine('\t' + "Інтерація №" + k + '\n' + "a=" + a + "S=" + S + "\n");
                y = x*Math.Cos(2*x);
                Console.WriteLine('\t' + "   Результати:" + '\n' + "Заданий x=" + x + '\n' + "Сумма ряду S=" + S + '\n' + "Кількість членів ряду" + k + '\n' + "Функція x=" + y + '\n');
                Console.WriteLine('\n' + "Для повторго ввода" + "Натиснути любу клавішу" + '\n' + "Для завершення дії натиснути Enter");
                string rep = Console.ReadLine();
                if (rep != "") goto m1;
            }
        }
    }
}
