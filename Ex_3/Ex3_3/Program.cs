using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 23
        Напишите программу, которая принимает на вход число (N) 
        и выдаёт таблицу кубов чисел от 1 до N.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= number)
            {
                Console.Write($"Куб равен {Math.Pow(i, 3)}.");
                i++;
            }
        }
    }
}
