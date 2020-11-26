using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Tree
    {
        public Node<int> Node;
        public Node<int> Root = null;
        public Tree() { }

        /// <summary>
        /// Метод добавления в дерево
        /// </summary>
        /// <param name="data"></param>
        public void Add(int data)
        {
            if (Root == null)
            {
                Root = new Node<int>(data);
                return;
            }
            Node<int> node = Root;
            while (true)
            {
                if (data < node.data)
                {
                    if (node.Left == null)
                    {
                        node.Left = new Node<int>(data);
                        return;
                    }
                    else
                        node = node.Left;
                }
                if (data > node.data)
                {
                    if (node.Right == null)
                    {
                        node.Right = new Node<int>(data);
                        return;
                    }
                    else node = node.Right;
                }
                else
                    return;
            }
        }

        /// <summary>
        /// Свойство врзвращает корень дерева
        /// </summary>
        public Node<int> GetRoot => Root;

        /// <summary>
        /// Поиск узла по значению
        /// </summary>
        /// <param name="findData"></param>
        /// <param name="root">Узел начало поиска</param>
        /// <returns>Найденный узел</returns>
        public Node<int> Find(int findData, Node<int> root = null)
        {
            if (root == null || findData == root.data)
                return root;
            if (root.data < findData)
                return Find(findData, root.Left);
            else
                return Find(findData, root.Right);
        }

        /// <summary>
        /// Метод обхода дерева (корень-левая-правая)
        /// </summary>
        /// <param name="root"></param>
        public void CLR(Node<int> root, Side? side = null)
        {
            if (root != null)
            {
                var nodeSide = side == null ? "C" : side == Side.Left ? "L" : "R";
                Console.Write($"[{nodeSide}]-{root.data} ");
                if (root.Left != null) CLR(root.Left, Side.Left);
                if (root.Right != null) CLR(root.Right, Side.Right);
            }
        }

        /// <summary>
        /// Метод обхода дерева (левая-корень-правая)
        /// </summary>
        /// <param name="root"></param>
        public void LCR(Node<int> root, Side? side = null)
        {
            if (root != null)
            {
                var nodeSide = side == null ? "C" : side == Side.Left ? "L" : "R";
                if (root.Left != null) LCR(root.Left, Side.Left);
                Console.Write($"[{nodeSide}]-{root.data} ");
                if (root.Right != null) LCR(root.Right, Side.Right);
            }
        }

        /// <summary>
        /// Метод обхода дерева (правая-корень-левая)
        /// </summary>
        /// <param name="root"></param>
        public void RCL(Node<int> root, Side? side = null)
        {
            if (root != null)
            {
                var nodeSide = side == null ? "C" : side == Side.Left ? "L" : "R";
                if (root.Right != null) RCL(root.Right, Side.Right);
                Console.Write($"[{nodeSide}]-{root.data} ");
                if (root.Left != null) RCL(root.Left, Side.Left);
            }
        }
    }

    /// <summary>
    /// Список расположения узла относительно родителя
    /// </summary>
    public enum Side
    {
        Left,
        Right
    }
}
