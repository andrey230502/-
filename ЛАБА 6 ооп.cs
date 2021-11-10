using System;

namespace ЛАБ_раб_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            string strValue;
            int[] iArray1 = new int[20];

            for (j = 0; j < 20; j++)
            {
                strValue = Console.ReadLine();
                iArray1[j] = Convert.ToInt32(strValue);

            }
            Console.WriteLine("-------------------Положительные индексы в масиве--------------------");
            for (j = 0; j < 20; j++)
            {
                if (iArray1[j] >= 0)
                {
                    Console.WriteLine("iArray[" + j + "] =" + iArray1[j]);
                }
            }
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
