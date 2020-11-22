using System.Collections;
using System.Collections.Generic;

namespace Task_3
{
    /// <summary>
    /// Класс описывающий список
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyList<T> : IEnumerable<T>
    {
        Node<T> head; // головной/первый элемент
        Node<T> tail; // последний/хвостовой элемент
        int count; // количество элементов в списке

        /// <summary>
        /// Метод добавления в список
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;
            count++;
        }

        /// <summary>
        /// Метод удаления из списка
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Remove(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;
                        // Если current.Next не установлен, значит узел последний,
                        if (current.Next == null)
                            // изменяем переменную tail
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        head = head.Next;
                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = previous.Next;
            }
            return false;
        }

        /// <summary>
        /// Свойство возвращает длинну списка
        /// </summary>
        //public int Count { get { return count; } }
        public int Count => count;

        /// <summary>
        /// Свойство возвращает пустой ли список
        /// </summary>
        //public bool IsEmpty { get { return count == 0; } }
        public bool IsEmpty => count == 0;

        /// <summary>
        /// Метод очиски списка
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

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
        /// Метод добавления в начало списка
        /// </summary>
        /// <param name="data"></param>
        public void AppendFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
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
                yield return current.Data; // определяет возвращаемый элемент
                current = current.Next;
            }
        }
        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
