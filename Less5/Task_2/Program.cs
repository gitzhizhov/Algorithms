using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Написать  программу,  которая  определяет,  является  ли  введенная  скобочная 
/// последовательность правильной. 
/// Примеры  правильных скобочных  выражений:  (), ([])(),  { } (), ([{ }]),
/// неправильных — )(, ())({), (, ])}), ([(]) для скобок[, (, {. 
/// Например: (2 + (2 * 2)) или[2 /{ 5 * (4 + 7)}]. 
/// </summary>
 
// Андрей Жижов
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = new string[] { "()", "([])()", "{ } ()", "([{ }])", ")(", "())({)", "(", "])})", "([(])" , "(2+(2*2))", "[2/{5*(4+7)}]" };

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.WriteLine($"Последовательность: {sequence[i],7} - {CheckSequence(sequence[i])}");
            }

            //correct = CheckSequence(str);
            //Console.WriteLine($"Последовательность: {correct}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод проверки скобочной последовательности
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        static bool CheckSequence(string seq)
        {
            bool correct = false;
            Stack<char> stack = new Stack<char>();
            foreach (var c in seq)
            {
                if (c.Equals('[') || c.Equals('(') || c.Equals('{'))
                    stack.Push(c);
                if (c.Equals(']') || c.Equals(')') || c.Equals('}'))
                    if (stack.Count == 0)
                    {
                        correct = false;
                        break;
                    }
                    else
                        correct = CheckOpenBrace(stack.Pop());
            }
            if (stack.Count != 0)
                correct = false;

            return correct;
        }

        /// <summary>
        /// Метод провереяет закрывающие скобки
        /// </summary>
        /// <param name="brace"></param>
        /// <returns></returns>
        static bool CheckCloseBrace(char brace)
        {
            return (brace.Equals(')') || brace.Equals(']') || brace.Equals('}'));
        }

        /// <summary>
        /// Метод проверяет открывающиеся скобки
        /// </summary>
        /// <param name="brace"></param>
        /// <returns></returns>
        static bool CheckOpenBrace(char brace)
        {
            return (brace.Equals('(') || brace.Equals('[') || brace.Equals('{'));
        }
    }
}
