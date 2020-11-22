using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// *Реализовать  алгоритм  перевода  из  инфиксной  записи  арифметического  выражения  в 
/// постфиксную.
/// Реализовать очередь: 
/// 1.С использованием массива.
/// 2. *С использованием односвязного списка
/// </summary>

/// Андрей Жижов
namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inFix;
            //inFix = "5*6+(2-9)";
            string postFix = PostFix(inFix); // 56*29-+

            Console.WriteLine($"Инфиксная запись: {inFix}");
            Console.WriteLine($"Постфиксная запись: {postFix}");

            Console.ReadKey();
        }

        /// <summary>
        /// метод первода из инфексной записи в постфиксную
        /// </summary>
        /// <param name="inFix"></param>
        /// <returns></returns>
        static string PostFix(string inFix)
        {
            NodeStack<char> stack = new NodeStack<char>(); // стек
            Queue<char> queue = new Queue<char>(); // очередь

            string postFix = null;
            foreach (char it in inFix)
            {
                // Если входящий элемент число, то добавляем его в очередь
                if (CheckNumber(it))
                    queue.Enqueue(it);
                // Если входящий элемент оператор (+, -, *, /) то проверяем:
                if (CheckOperator(it))
                {
                    // Если стек пуст или содержит левую скобку в вершине, то добавляем входящий оператор в стек
                    if (stack.IsEmpty || stack.Peek() == '(')
                        stack.Push(it);

                    // Если входящий оператор имеет более высокий приоритет чем вершина, поместите его в стек
                    else if (!stack.IsEmpty && Priority(it) > Priority(stack.Peek()))
                        stack.Push(it);

                    // Если входящий оператор имеет более низкий или равный приоритет, чем вершине
                    else if (!stack.IsEmpty && Priority(it) <= Priority(stack.Peek()))
                    {
                        while (!stack.IsEmpty && (Priority(stack.Peek()) > Priority(it) || stack.Peek().Equals('(')))
                            // выгружаем POP в очередь, пока не увидите оператор с меньшим приоритетом или левую скобку на вершине
                            queue.Enqueue(stack.Pop());
                        // затем добавьте входящий оператор в стек
                        stack.Push(it);
                    }
                }
                // Если входящий элемент является левой скобкой, поместите его в стек
                if (it.Equals('('))
                    stack.Push(it);
                // Если входящий элемент является правой скобкой, выгружаем стек и добавляем его элементы в очередь, пока не увидите левую круглую скобку.
                if (it.Equals(')'))
                {
                    while (!stack.IsEmpty && !stack.Peek().Equals('('))
                        queue.Enqueue(stack.Pop());
                    //  Удалите найденную скобку из стека
                    stack.Pop();
                }

            }
            // В конце выгрузите стек в очередь
            if (!stack.IsEmpty)
                foreach (var e in stack)
                {
                    if (stack.Peek() != '(')
                        queue.Enqueue(stack.Pop());
                }

            foreach (var e in queue)
            {
                postFix += e;
            }

            return postFix;
        }

        /// <summary>
        /// Метод проверки на число
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static bool CheckNumber(char num)
        {
            if (num > 47 && num < 58)
                return true;
            return false;
        }

        /// <summary>
        /// Метод проверки, символ оператор.
        /// </summary>
        /// <param name="oper"></param>
        /// <returns></returns>
        static bool CheckOperator(char oper)
        {
            return (oper.Equals('+') || oper.Equals('-') || oper.Equals('*') || oper.Equals('/'));
        }

        /// <summary>
        /// Метод проверки приоритета операций
        /// </summary>
        /// <param name="oper"></param>
        /// <returns></returns>
        static byte Priority(char oper)
        {
            byte priority = 0;
            switch (oper)
            {
                case '+':
                case '-':
                    priority = 1;
                    break;
                case '*':
                case '/':
                    priority = 2;
                    break;
                default:
                    break;
            }
            return priority;
        }
    }
}
