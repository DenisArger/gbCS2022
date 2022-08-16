using System;
namespace ConsoleApp
{
    class Program
    {
        /*Задача 41: Пользователь вводит с клавиатуры M чисел. 
        Посчитайте, сколько чисел больше 0 ввёл пользователь.
        */
        static void Main(string[] arg)
        {
            Console.WriteLine("Сколько чисел хотите ввести?");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введите {i + 1}-е число");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вы ввели следующие числа:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();



            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    count++;

            }
            Console.WriteLine($"Вы ввели {count} чисел больше нуля.");

        }
    }
}
