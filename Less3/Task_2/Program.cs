using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 2. *Реализовать шейкерную сортировку. 
/// </summary>

/// Андрей Жижов
namespace Task_2
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

            int[] sortArr = ShakerSort(arr, ref step);

            Console.WriteLine("Отсортированный массив, сортировка Шейкером:");
            foreach (var item in sortArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nКол. шагов: {step}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод сортировки Шейкером
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        static int[] ShakerSort(int[] arr, ref int step)
        {
            step = 0;
            bool sort = false;
            int posLeft = 0;
            int posRight = arr.Length - 1;

            while(posLeft < posRight && sort == false)
            {
                //проход слева направо
                for (int i = 0; i < posRight; i++)
                {
                    sort = true;
                    step++;
                    if (arr[i] > arr[i + 1])
                    {
                        sort = false;
                        Swap(ref arr[i], ref arr[i + 1]);
                        step++;
                    }
                }
                posRight--;
                //проход справа налево
                for (int i = posRight; i > posLeft; i--)
                {
                    sort = true;
                    step++;
                    if (arr[i - 1] > arr[i])
                    {
                        sort = false;
                        Swap(ref arr[i - 1], ref arr[i]);
                        step++;
                    }
                }
                posLeft++;
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
