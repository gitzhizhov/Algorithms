using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1. Реализовать  функцию  перевода  чисел  из  десятичной  системы  в  двоичную,  используя 
/// рекурсию.
/// </summary>

/// Андрей Жижов
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // десятичное число
            string binary = "";

            Console.Write("Введите десятичное число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            binary = ToBinarySys(x);
            Console.WriteLine($"Десятичное число: {x} в двоичном системе: {binary}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод переводит  из  десятичной  системы  в  двоичную.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Строку</returns>
        private static string ToBinarySys(int x)
        {
            if (x > 0)
            {
                if (x < 2)
                    return x.ToString();
                else
                    return ToBinarySys(x / 2) + (x % 2).ToString();
            }
            return x.ToString(); ;
        }
    }
}
