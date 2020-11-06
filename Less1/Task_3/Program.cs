using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 3. Написать программу обмена значениями двух целочисленных переменных: 
/// a. с использованием третьей переменной;
/// b. * без использования третьей переменной.
/// </summary>

/// Андрей Жижов
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; // первое число
            int b; // второе число
            int t;

            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Первое число = {a}, Втрое число = {b}");
            Console.WriteLine("Замена значений");
            Console.WriteLine();

            /// <summary>
            /// Метод обмена значений двух переменных с использованием третье переменной.
            /// </summary>
            void Change1()
            {
                t = a;
                a = b;
                b = t;
            }

            /// <summary>
            /// Метод обмена значений двух переменных без использованием третье переменной.
            /// </summary>
            void Change2()
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            //Change1();
            Change2();

            Console.WriteLine("Значения переменных после замены");
            Console.WriteLine($"Первое число = {a}, Втрое число = {b}");

            Console.ReadKey();
        }
    }
}
