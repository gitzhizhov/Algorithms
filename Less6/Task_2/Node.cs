using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    /// <summary>
    /// Класс узла дерева
    /// </summary>
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            this.data = data; 
        }
    }
}
