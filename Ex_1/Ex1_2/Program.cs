// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 4: Напишите программу, которая принимает на вход три числа 
        и выдаёт максимальное из этих чисел.
*/
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите 1-е число");
            int oneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число");
            int twoNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3-е число");
            int threeNumber = Convert.ToInt32(Console.ReadLine());
            compareThreeNumbers(oneNumber, twoNumber, threeNumber);

            void compareThreeNumbers(int oneNumber, int twoNumber, int threeNumber)
            {
                int maxNumber = oneNumber;
                if (twoNumber >= maxNumber)
                {
                    maxNumber = twoNumber;
                }
                if (threeNumber >= maxNumber)
                {
                    maxNumber = threeNumber;
                }

                Console.WriteLine($"Число: {maxNumber} максимальное.");

            }
        }
    }
}
