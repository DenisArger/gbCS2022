// See https://aka.ms/new-console-template for more information
using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите 1-е число");
            int oneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число");
            int twoNumber = Convert.ToInt32(Console.ReadLine());
            compareTwoNumbers(oneNumber, twoNumber);



            void compareTwoNumbers(int oneNumber, int twoNumber)
            {
                int div = oneNumber - twoNumber;
                if (div > 0)
                {
                    Console.WriteLine($"Число: {oneNumber} большее, число: {twoNumber} меньшее.");
                }
                else if (div < 0)
                {
                    Console.WriteLine($"Число: {twoNumber} большее, число: {oneNumber} меньшее.");
                }
                else
                    Console.Write("Числа равны.");

            }
        }
    }
}
