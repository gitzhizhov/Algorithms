using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2. Найти максимальное из четырех чисел. Массивы не использовать.
/// Сделал допуск. Если 2 числа равны, то макимальное первое число.
/// </summary>

/// Андрей Жижов
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1; // число 1
            int x2; // число 2
            int x3; // число 3
            int x4; // число 4
            int max; // максимальное число

            Console.Write("Введите первое число: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            x4 = Convert.ToInt32(Console.ReadLine());

            
            int Max(int a, int b)
            {
                if (a == b)
                    max = a;
                if (a < b)
                    max = b;
                else
                    max = a;
                return max;
            }

            max = Max(Max(x1, x2), Max(x3, x4));

            Console.WriteLine();
            Console.WriteLine($"Максимальное число равно: {max}");
            Console.ReadKey();
        }
    }
}
