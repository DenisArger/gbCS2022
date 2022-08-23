using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 64: Задайте значения M и N. 
        Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите значение M");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N");
            int numberN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Все натуральные числа кратные 3-ём:");
            multipleNumber(numberM, numberN);

            int multipleNumber(int numberM, int numberN)
            {
                if (numberM > numberN)
                    return numberM;
                if (numberM % 3 == 0)
                    Console.WriteLine($"{numberM}");
                numberM++;
                return multipleNumber(numberM, numberN);
            }

        }
    }
}
