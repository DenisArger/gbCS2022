using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 10: Напишите программу, которая принимает 
        на вход трёхзначное число и на выходе 
        показывает вторую цифру этого числа.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите  трёхзначное  число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Вы ввели  не трёхзначное  число");
                return;
            }

            number = (number / 10) % 10;
            Console.Write($"{number} ");




        }
    }
}
