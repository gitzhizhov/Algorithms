using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class AlgorithmSorting
    {
        Random rnd;

        /// <summary>
        /// Метод заполнения массива случайными числами
        /// </summary>
        /// <param name="arryaSize">Размер массива</param>
        /// <param name="min">Минимальное число</param>
        /// <param name="max">Максимальное число</param>
        /// <returns></returns>
        public int[] GetRandomArray(int arryaSize, int min, int max)
        {
            rnd = new Random();
            int[] arrya = new int[arryaSize];
            for (int i = 0; i < arrya.Length; i++)
            {
                arrya[i] = rnd.Next(min, max + 1);
            }
            return arrya;
        }
        
        /// <summary>
        /// Метод вывода массива в консоль
        /// </summary>
        /// <param name="arr"></param>
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        /// <summary>
        /// Метод перестановки
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        /// <summary>
        /// Метод реализует алгоритм сортировки подсчетом
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] CountingSort(int[] array)
        {
            // поиск минимального и максимального значения
            int min = array[0]; // минимальное значение
            int max = array[0]; // максимальное значение
            foreach (var el in array)
            {
                if (el > max)
                    max = el;
                if (el < min)
                    min = el;
            }

            int[] count = new int[max + 1]; // вспомогательный массив

            for (int i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }
            int index = 0;
            // значения из вспомогательного массива в итоговый массив
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }

        /// <summary>
        /// Метод быстрой сортировки
        /// </summary>
        /// <param name="array"></param>
        public void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Метод быстрой сортировки
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        private void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = rnd.Next(left, right); // опорный индекс выбирается случайно
                int newPivot = Partition(array, left, right, pivotIndex);

                QuickSort(array, left, newPivot - 1);
                QuickSort(array, newPivot + 1, right);
            }
        }

        /// <summary>
        /// Метод сортироваки в массиве\подмассиве отностельно опорного элементы
        /// </summary>
        /// <param name="array">массив</param>
        /// <param name="left">начальный индекс</param>
        /// <param name="right">конечный индекс</param>
        /// <param name="pivotIndex">Опорный индекс</param>
        /// <returns></returns>
        private int Partition(int[] array, int left, int right, int pivotIndex)
        {
            int pivotValue = array[pivotIndex]; // значение опорного индекса

            Swap(ref pivotValue, ref array[right]);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (array[i].CompareTo(pivotValue) < 0)
                {
                    Swap(ref array[i], ref array[storeIndex]);
                    storeIndex += 1;
                }
            }
            Swap(ref array[storeIndex], ref array[right]);
            return storeIndex;
        }
    }
}
