using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 10.  Дано  целое  число N (> 0). С помощью операций деления нацело и взятия остатка от деления 
/// определить, имеются ли в записи числа N нечетные цифры.Если имеются, то вывести True, если нет 
/// — вывести False.
/// </summary>

/// Андрей Жижов
namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("Введите число N (> 0): ");
            N = Convert.ToInt32(Console.ReadLine());

            if (N > 0)
            {
                Console.WriteLine(CheckUneven(N));
            }
            else
                Console.WriteLine("Введеное число должно быть положительным");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод проверяет наличеи не четных цифр в числе. Если есть возращает true
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        private static bool CheckUneven(int N)
        {
            bool uneven = false;
            while (N > 0)
            {
                if (N % 2 != 0)
                {
                    uneven = true;
                    break;
                }
                N /= 10;
            }
            return uneven;
        }
    }
}
