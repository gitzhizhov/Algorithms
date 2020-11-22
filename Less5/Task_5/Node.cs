namespace Task_5
{
    /// <summary>
    /// Класс узла, который будет представлять одиночный объект в списке
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}
