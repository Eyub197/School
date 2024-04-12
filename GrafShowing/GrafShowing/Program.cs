using System;
using System.Collections.Generic;
using System.Linq;
namespace GrafShowing
{
    class Program
    {
        static void Main(string[] args)
        {
            //1zad
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //List<int>[] graph = new List<int>[n + 1];

            //for (int i = 1; i <= n; i++)
            //    graph[i] = new List<int>();


            //for (int i = 0; i < m; i++)
            //{
            //    var rebro = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //    int u = rebro[0];
            //    int v = rebro[1];
            //    graph[u].Add(v);
            //    graph[v].Add(u);
            //}

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"{i}: ");

            //    graph[i].Sort();

            //    Console.WriteLine(string.Join(" ", graph[i]));
            //}


            // Прочитане на броя върхове и ребра
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            // Създаване на матрица на съседствата
            int[,] adjacencyMatrix = new int[n + 1, n + 1];

            // Запълване на матрицата
            for (int i = 0; i < m; i++)
            {
                var edge = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int u = edge[0];
                int v = edge[1];

                adjacencyMatrix[u, v] = 1;
                adjacencyMatrix[v, u] = 1;
            }

            // Извеждане на матрицата
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}: ");
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{adjacencyMatrix[i, j]} ");
                }

                Console.WriteLine();
            }

        }    
    }
}
