using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 3. **Исполнитель  «Калькулятор»  преобразует  целое  число,  записанное  на  экране.  У 
/// исполнителя две команды, каждой присвоен номер:  
///      1.Прибавь 1.
///      2.Умножь на 2.
/// Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза. Сколько 
/// существует программ, которые число 3 преобразуют в число 20: 
///      а.С использованием массива. 
///      b. *С использованием рекурсии.
/// </summary>

/// Андрей Жижов
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 3; // начальное число
            int e = 20; // конечное число
            int p = 1; // сколько прибавляем
            int m = 2; // насколько умножаем
            int prog;

            prog = CalcArr(s, e, p, m);
            Console.WriteLine($"Кол. программ преобразующте число {s} в число {e} равно: {prog}");
            Console.WriteLine();

            prog = CalcRecursion(s, e, p, m);
            Console.WriteLine($"Кол. программ преобразующте число {s} в число {e} равно: {prog}");
            Console.ReadKey();
        }

        /// <summary>
        /// Метод подсчитывет кол. программ для преобразования числа s в число e с помощью прибавления числа p и умнажении на число m
        /// Используем массив оганиченный длинной в 100
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int CalcArr(int s, int e, int p, int m)
        {
            int[] arr = new int[100];
            arr[s] = 1;

            for (int i = s + 1; i <= e; i++)
            {
                arr[i] = i % 2 == 0 ? arr[i / m] + arr[i - p] : arr[i - p];
            }

            return arr[e];
        }

        /// <summary>
        /// Метод подсчитывет кол. программ для преобразования числа s в число e с помощью прибавления числа p и умнажении на число m
        /// использ
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int CalcRecursion(int s, int e, int p, int m)
        {
            if (s == e)
                return 1;
            if (s > e)
                return 0;
            return CalcRecursion(s + p, e, p, m) + CalcRecursion(s * m, e, p, m);
        }
    }
}
