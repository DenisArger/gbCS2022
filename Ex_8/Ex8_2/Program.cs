using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 56: Задайте прямоугольный двумерный массив.
         Напишите программу, которая будет находить строку 
         с наименьшей суммой элементов.
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
                int sum = 0;
                int sumMin = 2147483647;
                int strMin = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    sum = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }
                    Console.WriteLine(@$"Cумма элементов строки под номером {i + 1} равна {sum}");
                    if (sum < sumMin)
                    {
                        sumMin = sum;
                        strMin = i + 1;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(@$"Cтрока с наименьшей суммой элементов под номером {strMin}");

            }
        }
    }
}
