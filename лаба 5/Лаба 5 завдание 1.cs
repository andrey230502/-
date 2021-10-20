using System;
using System.IO;

namespace laba_5__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter p = new StreamWriter("laba5.txt");
            float a, x, y;
            p.WriteLine("Результат");
            for (a = 0.5f; a <= 2.0f; a += 0.5f)
            {
                p.WriteLine("a=" + a);
                for (x = -2; x <= 2; x += 0.05f) 
                {
                    if (a < 0)
                    {
                        p.WriteLine("Негативний");
                    }
                    if (Math.Sqrt(a) == 0)
                    {
                        p.WriteLine("На нуль ділити не можна");
                    }
                    else
                    {
                        y = (float)(Math.Pow(a, 3)) / (Math.Pow(a, 2)) + (Math.Pow(x, 2);
                        p.WriteLine("   x=   " + x + '\t' + "   y=   " + y);
                    }
                }
            }
            p.Close();
        }
    }
}
