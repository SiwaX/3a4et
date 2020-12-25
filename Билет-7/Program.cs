using System;

namespace Билет_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] array = new int[L];
            for (int i = 0; i < L; i++)
            {
                array[i] = rnd.Next(1, 9);
                Console.Write(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(NOD(array));
        }

        static double NOD(int[] array)
        {
            int sum = 0;
            int count = 0;
            foreach(int el in array)
            {
                sum += el;
                count++;
                
            }
            double result = (double)sum / count;
            return result;
        }
    }
}
