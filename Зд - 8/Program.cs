using System;

namespace Зд___8
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

            Console.WriteLine();
            Console.WriteLine(arr);
        }

        static void Sort(ref int[,] array, out int[,] array1)
        {
            array1 = new int[array.GetLength(0),array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < array.GetLength(0); j++)
                {
                    if (array[i, 0] > array[j, 0])
                    {
                        int tmp = array[i, 0];
                        array[i, 0] = array[j, 0];
                        array[j, 0] = tmp;
                    }
                }
            }
        }
    }
}
