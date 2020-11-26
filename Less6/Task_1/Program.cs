using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Реализовать простейшую хэш-функцию. На вход функции подается строка, на выходе сумма кодов 
/// символов.
/// </summary>

/// Андрей Жижов
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int hashCountChar;
            str = "12D4"; // 219

            hashCountChar = GenHash(str);
            Console.WriteLine($"Строка: {str}");
            Console.WriteLine($"Сумма кодов символов равна: {hashCountChar}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод подсчета суммы кодов символов
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static int GenHash(string str)
        {
            int hash = 0;
            foreach (char с in str)
            {
                hash = hash + (int)с;
            }
            return hash;
        }
    }
}
