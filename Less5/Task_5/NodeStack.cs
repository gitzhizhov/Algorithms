using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_5
{
    /// <summary>
    /// Класс стека
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class NodeStack<T> : IEnumerable<T>
    {
        Node<T> head;
        int count;

        /// <summary>
        /// Свойство проверки на пустой стек
        /// </summary>
        public bool IsEmpty => count == 0;

        /// <summary>
        /// Свойство возвращает количество элементов
        /// </summary>
        public int Count => count;

        /// <summary>
        /// Метод проверки содежит ли список элемент
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        /// <summary>
        /// Метод вставляет объект как верхний элемент стека
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            Node<T> node = new Node<T>(data); // увеличиваем стек
            node.Next = head; // переустанавливаем верхушку стека на новый элемент
            head = node;
            count++;
        }

        /// <summary>
        /// Метод удаляет и возвращает объект находящийся в начале стека
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            Node<T> tmp = head;
            head = head.Next; // переустанавливаем верхушку стека на следующий элемент
            count--;
            return tmp.Data;
        }

        /// <summary>
        /// Метод возвращает объект, находящийся в начале стека без его удаления
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return head.Data;
        }

        /// <summary>
        /// Метод перебора элементов
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
