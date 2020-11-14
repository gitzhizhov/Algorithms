using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 3.  Реализовать  бинарный  алгоритм  поиска  в  виде  функции,  которой  передается отсортированный 
/// массив. Функция возвращает индекс найденного элемента или -1, если элемент не найден.
/// </summary>

/// Андрей Жижов
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 0; // кол. шагов
            int[] arr = new int[] { 0, -10, -2, 1, 2, 4, 5, 3, 15, 11, 7, 8, 9, 12, 6, 10, 99, 100, -45, 20 };
            int num = 15;

            int[] sortArr = InsertionSort(arr, ref step);
            Console.WriteLine("Отсортированный массив, сортировка Вставками:");
            foreach (var item in sortArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nКол. шагов: {step}");
            Console.WriteLine();

            int index = BinarFind(arr, num);
            Console.WriteLine($"Позиция в массиве: {index}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод бинарного поиска в массиве
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        static int BinarFind(int[] arr, int index)
        {
            int posLeft = 0;
            int posRight = arr.Length - 1;
            while (posLeft < posRight)
            {
                int posMid = (posRight + posLeft) / 2;
                if (index <= arr[posMid])
                    posRight = posMid;
                else
                    posLeft = posMid + 1;
            }
            if (arr[posRight] == index)
                return posRight;
            return -1;
        }

        /// <summary>
        /// Метод сортировки массива вставками
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        static int[] InsertionSort(int[] arr, ref int step)
        {
            step = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                int j = i;
                while (j > 0 && arr[j - 1] > tmp)
                {
                    Swap(ref arr[i - 1], ref arr[i]);
                    step++;
                    j--;
                }
            }
            return arr;
        }

        /// <summary>
        /// Метод обмена элементов
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        static void Swap(ref int e1, ref int e2)
        {
            var tmp = e1;
            e1 = e2;
            e2 = tmp;
        }
    }
}
