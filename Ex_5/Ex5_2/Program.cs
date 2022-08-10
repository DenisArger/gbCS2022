using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        Найдите сумму элементов, стоящих на нечётных позициях.
        */
        static void Main(string[] arg)
        {
            int size = 8;
            int[] array = new int[size];
            Random random = new Random();
            int sumNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-9, 9);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                    sumNumber += array[i];
            }
            Console.Write($"Cумму элементов, стоящих на нечётных позициях  равна {sumNumber}.");

        }
    }
}
