﻿// See https://aka.ms/new-console-template for more information
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
            Console.WriteLine("Введите  число");
            int number = Convert.ToInt32(Console.ReadLine());
            isEven(number);

            void isEven(int number)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"Число: {number} четное.");
                }
                else
                {
                    Console.WriteLine($"Число: {number} нечетное.");
                }
            }
        }
    }
}
