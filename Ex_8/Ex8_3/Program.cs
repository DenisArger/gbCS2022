using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.
        */
        static void Main(string[] arg)
        {
            int rows = 4;
            int columns = 4;
            int[,] array = new int[rows, columns];

            FillArray(array);
            PrintArray(array);


            void FillArray(int[,] array)
            {
                Console.WriteLine("Инициализация массива...");
                int counter = 1;
                int startCol = 0;
                int endCol = array.GetLength(0) - 1;
                int startRow = 0;
                int endRow = array.GetLength(1) - 1;

                while (startCol <= endCol && startRow <= endRow)
                {
                    for (int i = startCol; i <= endCol; i++)
                    {
                        array[startRow, i] = counter;
                        counter++;
                    }
                    startRow++;
                    for (int j = startRow; j <= endRow; j++)
                    {
                        array[j, endCol] = counter;
                        counter++;
                    }

                    endCol--;

                    for (int i = endCol; i >= startCol; i--)
                    {
                        array[endRow, i] = counter;
                        counter++;
                    }

                    endRow--;
                    for (int i = endRow; i >= startRow; i--)
                    {
                        array[i, startCol] = counter;
                        counter++;
                    }

                    startCol++;

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


        }
    }
}
