using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 13: Напишите программу,
         которая выводит третью цифру заданного числа 
         или сообщает, что третьей цифры нет.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("Третьей цифры нет.");
                return;
            }
            while (number > 999)
            {
                number /= 10;
            }
            number = number % 10;
            Console.Write($"Третья цифра равна {number}.");
        }
    }
}
