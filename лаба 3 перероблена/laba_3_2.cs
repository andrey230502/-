using System;
using System.IO;

namespace laba3_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // Розпізнавання укрїнських літер
            string s;
            double x, y;
            StreamWriter f = new StreamWriter("laba3_2_.res"); // виведення 
            StreamReader f1 = new StreamReader("laba3_2_.txt"); // введення
            f.WriteLine("Таблиця \n********************************\nI      *X      *     Y     *\n********************************");
        metka: s = f1.ReadLine();
            if (s == null) goto metka1;
            x = Convert.ToDouble(s);
            y = 2d * Math.PI / Math.PI + Math.Pow(x, 2);
            f.WriteLine("* x = {0:f3} * y = {1:e3} * \n", x, y);
            goto metka;
        metka1: f.WriteLine("*********************************\nРозробив Каранський Андрій Вадимович {0} \n", s);
            f.Close();
            f1.Close();
        }
    }
}
