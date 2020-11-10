using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2. Реализовать функцию возведения числа a в степень b: 
/// a.Без рекурсии.
/// b.Рекурсивно.
/// c. *Рекурсивно, используя свойство чётности степени. 
/// </summary>

/// Андрей Жижов
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int res;

            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            res = Pow(a, b);
            Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {res}");
            Console.WriteLine();

            res = PowRecursion(a, b);
            Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {res}");
            Console.WriteLine();

            res = PowRecursionParity(a, b);
            Console.WriteLine($"Результат возведения числа {a} в степень {b} равен {res}");
            Console.WriteLine();

            Console.ReadKey();
        }

        /// <summary>
        /// Метод возведения числа в степень
        /// </summary>
        /// <param name="a">Число</param>
        /// <param name="b">Степень</param>
        /// <returns>Число</returns>
        static int Pow(int a, int b)
        {
            int res = a;
            while (b > 1)
            {
                res *= a;
                b--;
            }
            return res;
        }

        /// <summary>
        /// Метод возведения числа в степень с использованием рекурсии
        /// </summary>
        /// <param name="a">Число</param>
        /// <param name="b">Степень</param>
        /// <returns></returns>
        static int PowRecursion(int a, int b)
        {
            if (b == 1)
                return a;
            return PowRecursion(a, b - 1) * a;
        }

        /// <summary>
        /// Метод возведения числа в степень с использованием рекурсии и свойством чётности степени
        /// </summary>
        /// <param name="a">Число</param>
        /// <param name="b">Степень</param>
        /// <returns></returns>
        static int PowRecursionParity(int a, int b)
        {
            if (b == 1)
                return a;
            if (b % 2 != 0)
                return PowRecursionParity(a, b - 1) * a;
            else
                return PowRecursionParity(a * a, b / 2);
        }
    }
}
