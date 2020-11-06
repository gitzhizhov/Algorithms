using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 11. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать среднее арифметическое всех 
/// положительных четных чисел, оканчивающихся на 8.
/// </summary>

/// Андрей Жижов
namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; // вводимые числа
            int sum = 0;
            int count = 0; // количество

            while (true)
            {
                Console.Write("Введите число: ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                    break;
                if (a > 0 || a % 2 == 0 || a == 8 || a % 10 == 8)
                {
                    sum += a;
                    count++;
                }
            }
            Console.WriteLine($"Среднее арифметическое всех положительных четных чисел,\n оканчивающихся на 8 = {sum / count}\n всего чисел {count}");

            Console.ReadKey();
        }
    }
}
