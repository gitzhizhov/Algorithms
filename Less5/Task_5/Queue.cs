using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_5
{
    /// <summary>
    /// Класс очереди
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Queue<T> : IEnumerable<T>
    {
        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count;

        /// <summary>
        /// Метод добавления в очередь
        /// </summary>
        /// <param name="data"></param>
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tmpNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tmpNode.Next = tail;
            count++;
        }

        /// <summary>
        /// Метод удаления из очереди
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }

        /// <summary>
        /// Свойство, получаем первый элемент очереди
        /// </summary>
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }

        /// <summary>
        /// Свойство, получаем последний элемент очереди
        /// </summary>
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }

        /// <summary>
        /// Свойство, получаем количество элементов
        /// </summary>
        public int Count { get { return count; } }

        /// <summary>
        /// Свойство, проверяем не пуста ли очередь
        /// </summary>
        public bool IsEmpty { get { return count == 0; } }

        /// <summary>
        /// Метод очистки очереди
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        /// <summary>
        /// Метод проверки, содержить ли очередь элемент
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



        IEnumerator<T> IEnumerable<T>.GetEnumerator()
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
