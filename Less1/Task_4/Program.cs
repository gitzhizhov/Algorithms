using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 4. Написать программу нахождения корней заданного квадратного уравнения.
/// a(x * x) + bx + c = 0; a!=0
/// </summary>

/// Андрей Жижов
namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a; // первый коэф
            double b; // второй коэф
            double c; // свободный член

            Console.Write("Введите значения первого коэффицента: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значения второго коэффицента: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значения свободного члена: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Result(a, b, c);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод вычисляет корни квадратного уравнения
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        private static void Result(double a, double b, double c)
        {
            double D; // дискриминант
            double x1; // первый корень
            double x2; // второй корень

            D = b * b - (4 * a * c);

            if (D > 0)
            {
                D = Math.Sqrt(D);
                x1 = (-b + D) / (2 * a);
                x2 = (-b - D) / (2 * a);
                Console.WriteLine("В квадратном уравнении 2 корня.");
                Console.WriteLine($"Первый корень: {x1:0.00}\nВторой корень: {x2:0.00}");
            }

            if (D == 0)
            {
                x1 = (-b) / (2 * a);
                Console.WriteLine("В квадратном уравнении 1 корнь.");
                Console.WriteLine($"Корень: {x1:0.00}");
            }

            if (D < 0)
                Console.WriteLine("В квадратном уравнении нет корней.");
        }
    }

}
