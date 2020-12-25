using System;

namespace Билет_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NOD(5,3,1,6,7,4,3));
        }

        static double NOD(int a, int b)
        {
            int sum = a + b;
            return (double)sum / 2;
        }
        static double NOD(int a, int b, int c)
        {
            int sum = a + b + c;
            return (double)sum / 3;
        }
        static double NOD(params int[] array)
        {
            int sum = 0;
            int count = 0;
            foreach(int el in array)
            {
                sum += el;
                count++;
            }
            return (double)sum / count;
        }

    }
}
