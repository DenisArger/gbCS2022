using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
        максимальным и минимальным элементов массива.
        */
        static void Main(string[] arg)
        {
            int size = 8;
            double[] array = new double[size];
            Random random = new Random();
            // int sumNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(random.NextDouble() * 100 - 50, 2);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            double minNumber = 0;
            double maxNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                    maxNumber = array[i];
                if (array[i] < minNumber)
                    minNumber = array[i];
            }
            Console.WriteLine($"Максимальный элемент массива: {maxNumber}.");
            Console.WriteLine($"Минимальный элемент массива: {minNumber}.");
            Console.WriteLine($"Разницу между максимальным и минимальным элементов массива: {maxNumber - minNumber}.");

        }
    }
}
