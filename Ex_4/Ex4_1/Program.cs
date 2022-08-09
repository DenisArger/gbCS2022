using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 25: Используя определение степени числа, напишите цикл, 
        который принимает на вход два натуральных числа (A и B) 
        и возводит число A в степень B.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите число A");
            int numberA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int numberB = Convert.ToInt32(Console.ReadLine());
            double pow = 1;
            for (int i = 0; i < numberB; i++)
            {
                pow = pow * numberA;
            }
            Console.Write($"Число {numberA} в степени {numberB} равно {pow}");

        }
    }
}
