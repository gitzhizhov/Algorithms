using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// *Создать  функцию,  копирующую  односвязный  список  (то  есть  создающую  в  памяти  копию 
/// односвязного списка без удаления первого списка).
/// </summary>

/// Андрей Жижов
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> firstList = new MyList<int>();
            MyList<int> cloneList = new MyList<int>();
            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            firstList.Add(5);

            foreach (var item in firstList)
            {
                cloneList.Add(item);
            }

            Console.WriteLine("Певый список: ");
            PrintList(firstList);
            Console.WriteLine();
            Console.WriteLine("Список копия: ");
            PrintList(cloneList);

            Console.ReadKey();
        }

        /// <summary>
        /// метод вывода на печать списка
        /// </summary>
        /// <param name="firstList"></param>
        private static void PrintList(MyList<int> firstList)
        {
            foreach (var item in firstList)
            {
                Console.Write($"{item,3}");
            }
        }
    }
}
