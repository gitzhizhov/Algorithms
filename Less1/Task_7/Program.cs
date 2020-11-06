using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 7. С клавиатуры вводятся числовые координаты двух полей шахматной доски (x1,y1,x2,y2). Требуется 
/// определить, относятся ли к поля к одному цвету или нет.
/// </summary>

/// Андрей Жижов
namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int y1;
            int x2;
            int y2;

            Console.Write("Введите координаты первой клетки по горизонтали (1 - 8) x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты первой клетки по вертикали (1 - 8) y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты второй клетки по горизонтали (1 - 8) x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координаты второй клетки по вертикали (1 - 8) y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            CheckingColorMatches(x1, y1, x2, y2);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод проверяет на совпадение цветов указанных клеток шахматной доски
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        private static void CheckingColorMatches(int x1, int y1, int x2, int y2)
        {
            if ((x1 + y1 + x2 + y2) % 2 == 0)
                Console.WriteLine("Цвета поля относятся к одному цвету");
            else
                Console.WriteLine("Цвета поля относятся к разным цветам");
        }
    }
}
