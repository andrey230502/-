using System;

namespace лаба3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;// = -2.1;
            int i;// = 444;
            int c;// = 1000;
            bool l;// = true;
            string name;// = "Karanskiy";
            Console.WriteLine("input a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input i");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input c");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input l");
            l = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("input фамілія");
            name = Console.ReadLine();

            Console.WriteLine("Результати форматування \nName={0,1}\tl={1,4}", name, l);
            System.Console.WriteLine("\na={0,1:f1}\ti={1,3}\tc={2,1}", a, i, c);
            System.Console.WriteLine("\nЩоб вийти натисніть Enter");
            Console.ReadLine();
            System.Console.ReadLine();
        }
    }
}
