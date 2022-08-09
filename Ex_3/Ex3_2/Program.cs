using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 21: Напишите программу, которая принимает на
        вход координаты двух точек и находит расстояние между
        ними в 3D пространстве.

        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Введите координаты 1-ой точки");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты 2-ой точки");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)
             + (z2 - z1) * (z2 - z1));

            Console.Write($"Расстояние между точками равно {distance}");
        }
    }
}
