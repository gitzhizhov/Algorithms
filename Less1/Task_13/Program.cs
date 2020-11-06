using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 13. * Написать функцию, генерирующую случайное число от 1 до 100.  
/// с использованием стандартной функции rand()
/// без использования стандартной функции rand()
/// </summary>

/// Андрей Жижов
namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 100;
            int x;

            #region Стандартный Random
            x = StandartRandom(n1, n2);
            Console.WriteLine($"Случайное число: {x}");
            #endregion



            Console.ReadKey();
        }

        /// <summary>
        /// Метод возращает случайное число из диапазона с использованием стандартного Random
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        private static int StandartRandom(int n1, int n2)
        {
            int x;
            Random rnd = new Random();
            x = rnd.Next(n1, n2);
            return x;
        }
    }
}
