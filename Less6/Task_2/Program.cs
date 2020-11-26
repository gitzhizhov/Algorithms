using System;
using System.IO;
using System.Linq;

/// <summary>
/// Переписать программу, реализующее двоичное дерево поиска.  
/// а) Добавить в него обход дерева различными способами;
/// б) Реализовать поиск в двоичном дереве поиска;
/// в) *Добавить в программу обработку командной строки с помощью которой можно указывать 
/// из какого файла считывать данные, каким образом обходить дерево. 
/// </summary>

/// Андрей Жижов
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            string path;
            int[] arr;

            Console.Write("Введите название файла: ");
            path = Console.ReadLine();
            //path = "data.txt";

            if (File.Exists(path))
            {
                arr = ReadFile(path);
                for (int i = 0; i < arr.Length; i++)
                {
                    tree.Add(arr[i]);
                }

                TreeTraversal(tree);
            }
            else
                Console.WriteLine("Файл не найден");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод, выбора обхода дерева
        /// </summary>
        /// <param name="tree"></param>
        /// <param name="tour"></param>
        static void TreeTraversal(Tree tree)
        {
            Console.WriteLine("Варианты обхода дерева:");
            Console.WriteLine("1: Корень-Левая ветвь-Правая ветвь");
            Console.WriteLine("2: Левая ветвь-Правая ветвь-Корень");
            Console.WriteLine("3: Правая ветвь-Корень-Левая ветвь");
            Console.Write("Выберети способ обхода: ");
            int tour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (tour)
            {
                case 1:
                    tree.CLR(tree.GetRoot);
                    break;
                case 2:
                    tree.LCR(tree.GetRoot);
                    break;
                case 3:
                    tree.RCL(tree.GetRoot);
                    break;
                default:
                    Console.WriteLine("Ввариант обхода не выбран");
                    break;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод чтения из файла
        /// </summary>
        /// <param name="path">Файл</param>
        /// <returns>Массив цифр</returns>
        static int[] ReadFile(string path)
        {
            int[] arr = new int[path.Length];
            try
            {
                string file = File.ReadAllText(path);
                arr = file.
                    Split(new char[] { ' ', ';', ',' }, StringSplitOptions.RemoveEmptyEntries).
                    Select(n => int.Parse(n)).
                    ToArray();
            }
            catch (IOException e)
            {
                Console.WriteLine($"{e}");
            }
            return arr;
        }
    }
}
