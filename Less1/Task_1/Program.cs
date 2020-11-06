using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела по формуле I=m/(h*h); где 
/// m - масса тела в килограммах, h - рост в метрах. 
/// </summary>

/// Андрей Жижов
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double h; // рост человека
            double m; // вес человека
            double I; // индекс массы тела

            Console.Write("Введите рост человека в метрах (например 1,76): ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес человека в килограммах (например 78,2): ");
            m = Convert.ToDouble(Console.ReadLine());

            I = m / (h * h);

            Console.WriteLine();
            Console.WriteLine($"Индекс массы тела равен: {I}");

            Console.ReadKey();
        }
    }
}
