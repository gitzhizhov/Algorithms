﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            int[,] matrix1 =
            {
                {0, 4, 0, 0, 0, 0, 0, 8, 0},
                {4, 0, 8, 0, 0, 0, 0, 11, 0},
                {0, 8, 0, 7, 0, 4, 0, 0, 2},
                {0, 0, 7, 0, 9, 14, 0, 0, 0},
                {0, 0, 0, 9, 0, 10, 0, 0, 0},
                {0, 0, 4, 14, 10, 0, 2, 0, 0},
                {0, 0, 0, 0, 0, 2, 0, 1, 6},
                {8, 11, 0, 0, 0, 0, 1, 0, 7},
                {0, 0, 2, 0, 0, 0, 6, 7, 0}
            };

            int[,] matrix2 =
            {
                { 0, 4, 8, 3, 0, 0, 0, 0 },
                { 4, 0, 1, 0, 8, 6, 0, 0 },
                { 8, 1, 0, 8, 2, 0, 0, 0 },
                { 3, 0, 8, 0, 0, 0, 4, 0 },
                { 0, 8, 2, 0, 0, 2, 0, 5 },
                { 0, 6, 0, 0, 2, 0, 0, 3 },
                { 0, 0, 0, 4, 0, 0, 0, 2 },
                { 0, 0, 0, 0, 5, 3, 2, 0 }
            };

            var path = graph.dijkstra(matrix2, 3);
            graph.Print(path);

            Console.ReadKey();
        }
    }
}
