using System;

namespace Билет_6
{
       //1. Рассказать про статический класс и членов класса, статический конструктор.
       //2. Написать программу, в которой есть процедура, меняющая элементы двух массивов одного размера
       //местами (массивы являются одновременно входным и выходным). Вызвать эту процедуру минимум 1 раз.


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
            int[] array2 = new int[L];
            for (int i = 0; i < L; i++)
            {
                array2[i] = rnd.Next(1, 9);
                Console.Write(array2[i]);
            }
            TradeEL(array, array2,out int[] array3, out int[] array4);
            Console.WriteLine();
            foreach(int el in array3)
            {
                Console.Write(el);
            }
            Console.WriteLine();
            foreach(int el in array4)
            {
                Console.Write(el);
            }
        
        }

        public static void TradeEL(int[] array, int[] array2,out int[] array3,out int[] array4)
        {

            int tmp = 0;
            array3 = new int[array.Length];
            array4 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                tmp = array[i];
                array[i] = array2[i];
                array2[i] = tmp;
                array3[i] = array[i];
                array4[i] = array2[i];
                
            }
        }

    }
}
