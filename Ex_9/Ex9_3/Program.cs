using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 66: Задача 68: Напишите программу вычисления функции
         Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите значение M");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение N");
            int numberN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Функция Аккермана:");
            int resultA = funcA(numberM, numberN);
            Console.WriteLine($"{resultA}");


            int funcA(int m, int n)
            {
                if (m == 0)
                    return n + 1;
                else if (n == 0)
                    return funcA(m - 1, 1);
                else
                    return funcA((m - 1), funcA(m, n - 1));
            }
        }
    }
}
