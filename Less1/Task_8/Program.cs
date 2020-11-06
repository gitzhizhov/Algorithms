using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 8. Ввести a и b и вывести квадраты и кубы чисел от a до b.
/// </summary>

/// Андрей Жижов
namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; // первое число
            int b; // второе число

            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = a; i < b; i++)
            {
                int iS = i * i;
                int iC = iS * i;
                Console.WriteLine($"Число {i}: квадрат числа = {iS}, куб числа = {iC}");
            }

            Console.ReadKey();
        }
    }
}
