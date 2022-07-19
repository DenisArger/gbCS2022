using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 19: Напишите программу, которая принимает на
            вход пятизначное число и проверяет, является ли оно
            палиндромом.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите пятизначное число");
            string? numberStr = Console.ReadLine();
            int lenght = numberStr!.Length;
            if (lenght != 5)
            {
                Console.WriteLine("Вы ввели не пятизначное число");
                return;
            }
            bool state1 = numberStr[0] == numberStr[4];
            bool state2 = numberStr[1] == numberStr[3];
            bool stateFinal = state1 && state2;
            if (stateFinal)
                Console.Write($"Число {numberStr}  является палиндромом.");
            else
            {
                Console.Write($"Число {numberStr}  не является палиндромом.");

            }
        }
    }
}
