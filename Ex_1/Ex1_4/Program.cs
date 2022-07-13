// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 8: Напишите программу, которая на вход принимает число (N), 
        а на выходе показывает все чётные числа от 1 до N.
*/
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите  число");
            int N = Convert.ToInt32(Console.ReadLine());
            int number = 1;
            while (number <= N)
            {
                if (isEven(number))
                    Console.Write($"{number} ");

                number++;
            }

            bool isEven(int number)
            {
                if (number % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
