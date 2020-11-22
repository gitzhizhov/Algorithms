namespace Task_3
{
    /// <summary>
    /// Класс узла, который будет представлять одиночный объект в списке
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Data { get; set; } // свойство хранит данные
        public Node<T> Next { get; set; } // свойство ссылка на следующий объект
        // конструктор
        public Node(T data)
        {
            Data = data;
        }
    }
}
