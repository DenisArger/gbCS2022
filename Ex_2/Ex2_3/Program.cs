using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 15: Напишите программу, которая принимает на вход цифру, 
        обозначающую день недели, и проверяет, является ли этот день выходным.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 7)
            {
                Console.WriteLine("Такого нет дня недели.");
                return;
            }
            else if (number < 6)
            {
                Console.WriteLine("Нет. Это не выходной");
            }
            else
            {
                Console.WriteLine("Да. Это выходной");
            }
        }
    }
}
