using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Graph
    {
        int Size;
        bool[] sptSet; // массив посещённых вершин
        int[] dist; // вспомогательный массив в нем сохраняем растояние до каждого узла
        int topStart; // вершина старта

        /// <summary>
        /// Метод проверки минимальной дистанции до соседних вершин
        /// </summary>
        /// <param name="dist"></param>
        /// <param name="sptSet"></param>
        /// <returns></returns>
        public int MinDist(int[] dist, bool[] sptSet)
        {
            Size = dist.GetLength(0);
            int min = int.MaxValue; // минимальная дистанция до вершины
            int minIndex = 0; // номер вершины с коротким путем от текущей

            for (int i = 0; i < Size; i++)
            {
                if (sptSet[i] == false && dist[i] <= min)
                {
                    min = dist[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        /// <summary>
        /// Метод реализует алгоритм Дейкрста
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public int[] dijkstra(int[,] graph, int source)
        {
            --source;
            Size = graph.GetLength(0);
            sptSet = new bool[Size];
            dist = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[source] = 0; // дистанция до источника устанавливаем в 0

            for (int i = 0; i < Size - 1; i++)
            {
                int v = MinDist(dist, sptSet);
                sptSet[v] = true; // посетили вершину
                for (int j = 0; j < Size; j++)
                {
                    if (!sptSet[j] && graph[v, j] != 0 && dist[v] != int.MaxValue && dist[v] + graph[v, j] < dist[j])
                        dist[j] = dist[v] + graph[v, j];
                }
            }
            topStart = source + 1;
            return dist;
        }

        /// <summary>
        /// Метод вывода растояний от источника до вершин
        /// </summary>
        /// <param name="dist"></param>
        public void Print(int[] dist)
        {
            Size = dist.GetLength(0);
            Console.WriteLine($"Растояние от вершины {topStart} до вершин:");
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($"До вершина {i + 1}: минимальное растояние = {dist[i]}");
            }
        }

    }
}
