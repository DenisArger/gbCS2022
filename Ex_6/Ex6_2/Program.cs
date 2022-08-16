using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 43: Напишите программу, которая найдёт точку пересечения
        двух прямых, заданных уравнениями 
        y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
         задаются пользователем.
        */
        static void Main(string[] arg)
        {
            double x0 = 0, y0 = 0;
            Console.WriteLine("Введите b1");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k1");
            double k1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b2");
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k2");
            double k2 = Convert.ToInt32(Console.ReadLine());

            if (k1 == k2)
                Console.WriteLine("Прямые параллельны");
            else
            {
                x0 = (b2 - b1) / (k1 - k2);
                y0 = k1 * x0 + b1;
                Console.WriteLine($" Прямые пересекаются в точке {x0},{y0}.");
            }


        }
    }
}
