using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 12. Написать функцию нахождения максимального из трех чисел.
/// </summary>

/// Андрей Жижов
namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int[] arr;
            int max = 0;

            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            #region Arrai
            arr = new int[] { a, b, c };
            max = Max(arr);
            Console.WriteLine($"Максимальное число из введенных: {max}");
            #endregion

            #region If
            max = Max(Max(a, b), c);
            Console.WriteLine($"Максимальное число из введенных: {max}");
            #endregion

            Console.ReadKey();
        }

        /// <summary>
        /// Метод возвращает максимальное число в переданном массиве
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private static int Max(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }

            return max;
        }

        /// <summary>
        /// Метод возвращает максимальное из перданных чисел.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Маскимальное число</returns>
        private static int Max(int x, int y)
        {
            return x > y ? x : y;
        }
    }
}
