using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 66: Задайте значения M и N. 
        Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите значение M");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N");
            int numberN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Cумма натуральных чисел:");
            int sum = 0;
            sum = sumNumber(numberM, numberN, sum);
            Console.WriteLine($"{sum}");

            int sumNumber(int numberM, int numberN, int sum)
            {
                if (numberM > numberN)
                    return sum;
                sum += numberM;
                numberM++;
                return sumNumber(numberM, numberN, sum);
            }

        }
    }
}
