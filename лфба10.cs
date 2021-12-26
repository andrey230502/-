using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            State s1 = new State("Тип правління");
            Console.WriteLine("Клас State");
            s1.Print();
            s1.Clear();
            s1.GetYear();
            s1.MaxYear();
            Console.WriteLine();
            Republic r1 = new Republic("Республіка", "Народ");
            Console.WriteLine("Клас Republic");
            
            r1.Print();
            r1.ControlPeople(false);
            r1.Clear();
            Console.WriteLine();
            Monarchy m1 = new Monarchy("Монархія", "Монарх");
            Console.WriteLine("Клас Monarchy");
            m1.Print();
            Console.WriteLine();
            Kingdom k1 = new Kingdom("Монархія", "Монарх", 1);
            Console.WriteLine("Клас Kingdom");
            k1.Grow();
            k1.Falls();
            k1.Print();
            k1.Clear();
            Console.WriteLine();
        }
    }
}
