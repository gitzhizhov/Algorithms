using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 9. Даны целые положительные числа N и K. Используя только операции сложения и вычитания, найти 
/// частное от деления нацело N на K, а также остаток от этого деления.
/// </summary>

/// Андрей Жижов
namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N; // делимое
            int K; // делитель
            int q = 0; // частное
            int r; // остаток

            Console.Write("Введите делимое N: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите делитель K: ");
            K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (N >= K)
            {
                N -= K;
                q++;
            }
            r = N;
            Console.WriteLine($"При делении N/K частное = {q}, остаток = {r}");

            Console.ReadKey();
        }
    }
}
