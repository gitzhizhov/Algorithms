using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2. Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.
/// </summary>

/// Андрей Жижов
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = new char[] { 'g', 'e', 'e', 'k', 'b', 'r', 'a', 'i', 'n', 's' };
            char[] b = new char[] { 'g', 'e', 'e', 'k', 'm', 'i', 'n', 'd', 's' };

            LengthSequence(a, b);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод определения максимальной длинный последовательности
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void LengthSequence(char[] a, char[] b)
        {
            int[,] arrLength = new int[a.Length + 1, b.Length + 1]; // массив длин последовательностей

            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 1; j < b.Length; j++)
                {
                    arrLength[i, j] = a[i - 1] == b[j - 1] ? (arrLength[i - 1, j - 1] + 1) : MaxLength(arrLength[i - 1, j], arrLength[i, j - 1]);
                }
            }
            Print(arrLength);
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

        /// <summary>
        /// Метод возвращает максимальный элемент
        /// </summary>
        /// <param name="f"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        static int MaxLength(int f, int s)
        {
            if (f > s)
                return f;
            return s;
        }
    }
}
