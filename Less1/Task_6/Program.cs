using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 6.  Ввести возраст человека (от 1 до 150 лет) и вывести его вместе с последующим словом «год», 
/// «года» или «лет». 
/// </summary>

/// Андрей Жижов
namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int age; // возраст

            Console.Write("Введите возраст человека от 1 до 150: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            PrintAge(age);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод выводит возраст человека с с последующим словом «год», «года» или «лет».
        /// </summary>
        /// <param name="age"></param>
        private static void PrintAge(int age)
        {
            if (age > 0 & age <= 150)
            {
                if (age >= 10 & age <= 20)
                    Console.WriteLine($"Вам {age} лет");
                else if (age % 10 == 1)
                    Console.WriteLine($"Вам {age} год");
                else if (age % 10 == 2 || age % 10 == 3 || age % 10 == 4)
                    Console.WriteLine($"Вам {age} года");
                else if (age % 10 == 5 || age % 10 == 6 || age % 10 == 7 || age % 10 == 8 || age % 10 == 9 || age % 10 == 0)
                    Console.WriteLine($"Вам {age} лет");
                else
                    Console.WriteLine($"Вам {age} лет");
            }
            else
                Console.WriteLine("Введено не верный возраст!");
        }
    }

}
