using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения 
/// оптимизированной и  не  оптимизированной  программы.  Написать  функции  сортировки, которые 
/// возвращают количество операций.
/// </summary>
 
/// Андрей Жижов
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int step = 0; // кол. шагов
            int[] arr = new int[] { 0, -10, -2, 1, 2, 4, 5, 6, 6, 11, 7, 8, 9, 0, 6, 10, 99, 100, -45, 20 };

            Console.WriteLine("Не отсортированный массив:");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            int[] sortArr = BubbleSort(arr, ref step);

            Console.WriteLine("Отсортированный массив, обычная сортировка Пузырьком:");
            foreach (var item in sortArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nКол. шагов: {step}");
            
            Console.WriteLine();

            int[] sortArrFast = BubbleSortFast(arr, ref step);

            Console.WriteLine("Отсортированный массив, оптимизированная сотрировка Пузырьком:");
            foreach (var item in sortArrFast)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nКол. шагов: {step}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод сортировки пузырьком
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int[] BubbleSort(int[] arr, ref int step)
        {
            step = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    step++;
                    if (arr[i] > arr[j])
                    {
                        Swap(ref arr[i], ref arr[j]);
                        step++;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Метод сортировки пузырьком оптимизированная
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        static int[] BubbleSortFast(int[] arr, ref int step)
        {
            bool sort;
            step = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sort = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    step++;
                    if (arr[i] > arr[j])
                    {
                        sort = false;
                        Swap(ref arr[i], ref arr[j]);
                        step++;
                    }
                }
                if (sort)
                    break;
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
