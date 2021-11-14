using System;

namespace лаба7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 4;

            int i = 0, j = 0, k = N - 1;
            int tmp;

            int[,] array = new int[N, N]
            {
                {1, 0, 0, 7},
                {0, 2, 6, 0},
                {0, 5, 3, 0},
                {4, 0, 0, 4},
            };

            for (int z = 0; z < N; z++)
            {
                for (int l = 0; l < N; l++)
                {
                    Console.Write("{0} ", array[z, l]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            while (i < 4)
            {
                tmp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = tmp;
                i++; j++; k--;
            }

            for (int z = 0; z < N; z++)
            {
                for (int l = 0; l < N; l++)
                {
                    Console.Write("{0} ", array[z, l]);
                }
                Console.WriteLine();
            }
        }
    }
}
