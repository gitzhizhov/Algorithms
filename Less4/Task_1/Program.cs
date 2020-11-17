using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1.  *Количество  маршрутов  с  препятствиями.  Реализовать  чтение  массива  с  препятствием  и 
/// нахождение количество маршрутов. 
/// Например, карта: 
/// 3 3
/// 1 1 1
/// 0 1 0
/// 0 1 0
/// </summary>

/// Андрей Жижов
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Карта");
            int[,] Map =
            {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 0, 1, 1 },
                { 1, 1, 0, 1, 1 },
                { 1, 1, 0, 1, 1 }
            };
            // 0 - препятствие

            Print(Map);
            Console.WriteLine(new string('=', 15));
            Console.WriteLine("Кол. путей" + Environment.NewLine);
            ObobstacleAvoidance(Map);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод заполняет массив путей с учетом препятствий
        /// </summary>
        /// <param name="arr"></param>
        static void ObobstacleAvoidance(int[,] arr)
        {
            int[,] way = new int[arr.GetLength(0), arr.GetLength(1)]; // массив путей
            // условность, двигаться можно только вправо и вниз
            for (int i = 1; i < arr.GetLength(0); i++)
            {
                way[i, 0] = (arr[i, 0] == 1) ? 1 : 0;
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    way[0, j] = (arr[0, j] == 1) ? 1 : 0;
                    way[i, j] = (arr[i, j] == 1) ? way[i, j - 1] + way[i - 1, j] : 0;
                }
            }

            Print(way);
        }

        /// <summary>
        /// Метод вывода массива в консоль
        /// </summary>
        /// <param name="arr"></param>
        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
