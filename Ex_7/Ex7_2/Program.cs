using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 50. Напишите программу, которая на вход принимает позиции 
        элемента в двумерном массиве, и возвращает 
        значение этого элемента или же указание, что такого элемента нет.
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
            }

            void ShowArray(int[,] array)
            {
                int rows = array.GetLength(0);
                int columns = array.GetLength(1);

                Console.WriteLine("Введите позицию элемента");
                int rowIndex = Convert.ToInt32(Console.ReadLine());
                int columnIndex = Convert.ToInt32(Console.ReadLine());
                if (rowIndex > rows || columnIndex > columns)
                    Console.WriteLine("Такого элемента не существует");
                else
                    Console.Write(array[rowIndex - 1, columnIndex - 1] + " ");
            }
        }
    }
}
