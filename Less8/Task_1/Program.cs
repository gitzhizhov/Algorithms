using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Реализовать сортировку подсчетом.
/// Реализовать быструю сортировку
/// Реализовать сортировку слиянием
/// </summary>

/// Андрей Жижов
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgorithmSorting aSort;
            Stopwatch clock;
            int[] unSortedArr; // не отсортированный массив
            int[] sortedArr; // отсортированны массив
            int arrSize; // кол. элементов массива

            aSort = new AlgorithmSorting();
            clock = new Stopwatch();
            TimeSpan ts;

            arrSize = 1000;
            unSortedArr = aSort.GetRandomArray(arrSize, 0, 50);

            clock.Start();
            aSort.CountingSort(unSortedArr);
            clock.Stop();
            ts = clock.Elapsed;
            clock.Reset();
            Console.WriteLine($"Алгоритм сортировки подсчетом, элементов {arrSize}");
            Console.WriteLine($"Затраченное время: {ts}");

            Console.WriteLine();

            //clock.Start();
            clock.Restart();
            aSort.QuickSort(unSortedArr);
            clock.Stop();
            ts = clock.Elapsed;
            clock.Reset();
            Console.WriteLine($"Алгоритм сортировки подсчетом, элементов {arrSize}");
            Console.WriteLine($"Затраченное время: {ts}");

            Console.ReadKey();
        }
    }
}
