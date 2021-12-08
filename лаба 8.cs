using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = {
                      {1, 1, 1, 1},
                      {4, 5, 8, 3},
                      {9, 9, 9, 9},
                      {1, 1, 2, 0}
                        };

            Tuple<float, bool, int> max = new Tuple<float, bool, int>(-1, false, -1);
            Tuple<float, bool, int> min = new Tuple<float, bool, int>(-1, false, -1);
            for (int col = 0, sum = 0; col < A.GetLength(0); col++, sum = 0)
            {
                for (int row = 0; row < A.GetLength(1); sum += A[row, col], row++) ;
                if (max.Item1 < (float)sum / A.GetLength(1)) max = new Tuple<float, bool, int>((float)sum / A.GetLength(1), true, col);
                else
                    if (!min.Item2) min = new Tuple<float, bool, int>((float)sum / A.GetLength(1), true, col);
            }
            for (int i = 0, n; i < A.GetLength(1); i++)
            {
                n = A[i, min.Item3];
                A[i, min.Item3] = A[i, max.Item3];
                A[i, max.Item3] = n;
            }

            //Output 
            for (int row = 0, sum = 0; row < A.GetLength(0); row++, sum = 0)
            {
                for (int col = 0; col < A.GetLength(1); col++) Console.Write(A[row, col]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
