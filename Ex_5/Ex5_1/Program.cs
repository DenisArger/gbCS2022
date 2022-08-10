using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 34: Задайте массив заполненный случайными положительными 
        трёхзначными числами. 
        Напишите программу, которая покажет количество чётных чисел в массиве.
        */
        static void Main(string[] arg)
        {
            int size = 8;
            int[] array = new int[size];
            Random random = new Random();
            int countNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100, 999);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    countNumber++;
            }
            Console.Write($"В массиве {countNumber} четных чисел.");

        }
    }
}
