using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 52. Задайте двумерный массив из целых чисел. 
        Найдите среднее арифметическое элементов в каждом столбце.
        */
        static void Main(string[] arg)
        {
            Random random = new Random();
            int rows = random.Next(5, 10);
            int columns = random.Next(5, 10);
            int[,] array = new int[rows, columns];

            FillArray(array);
            PrintArray(array);
            ShowArray(array);



            void FillArray(int[,] array)
            {
                Console.WriteLine("Инициализация массива...");

                int rows = array.GetLength(0);
                int columns = array.GetLength(1);
                Random random = new Random();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = random.Next(0, 99);
                    }
                }
            }

            void PrintArray(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }

            void ShowArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(1) - 1; k++)
                        {
                            if (array[i, k] < array[i, k + 1])
                            {
                                int temp = array[i, k + 1];
                                array[i, k + 1] = array[i, k];
                                array[i, k] = temp;
                            }
                        }
                    }
                }
                PrintArray(array);
            }
        }
    }
}
