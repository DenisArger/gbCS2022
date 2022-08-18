using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 47. Задайте двумерный массив размером m×n, 
        заполненный случайными вещественными числами.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите количество строк");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int column = Convert.ToInt32(Console.ReadLine());

            double[,] array = new double[row, column];
            Random random = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * 100 - 50, 2);
                }
            }


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
