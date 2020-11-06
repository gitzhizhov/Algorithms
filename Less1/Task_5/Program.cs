using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 5. С клавиатуры вводится номер месяца. Требуется определить, к какому времени года он относится.
/// </summary>

/// Андрей Жижов
namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m; // номер месяца

            Console.Write("Введите номер месяца: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            GetSeason(m);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод определяет сезон по числу месяца в году
        /// </summary>
        /// <param name="m"></param>
        private static void GetSeason(int m)
        {
            if (m > 0 && m <= 12)
            {
                if (m > 2 & m < 6)
                    Console.WriteLine("Время года Весна");
                else if (m > 5 & m < 9)
                    Console.WriteLine("Время года Лето");
                else if (m > 8 & m < 12)
                    Console.WriteLine("Время года Осень");
                else
                    Console.WriteLine("Время года Зима");
            }
            else
                Console.WriteLine("Номер месяца введен не корректно!");
        }
    }

}
