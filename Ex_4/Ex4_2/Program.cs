using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 27: Напишите программу,
         которая принимает на вход число и выдаёт сумму цифр в числе.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int numberSave = number;
            int sumDigit = 0;
            while (number > 0)
            {
                sumDigit += number % 10;
                number /= 10;
            }
            Console.Write($"Сумма цифр числа {numberSave} равна {sumDigit}");
        }
    }
}
