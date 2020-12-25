using System;

namespace Зд___6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------------");
            int[,] arr = new int[N, L];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    arr[i, j] = rnd.Next(1, 9);
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(SumMatrix(arr));
        }

        public static int SumMatrix(int[,] array)
        {
            int N = array.GetLength(0);
            int Sum = 0;
            for (int i = 0; i < N; i++)
            {
                Sum += array[i,N - i - 1];
            }
            return Sum;
        }
    }
}
