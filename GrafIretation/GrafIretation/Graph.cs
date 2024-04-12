using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafIretation
{
    class Graph
    {
        internal int MaxNode = 1000;
        private int[][] childNodes;

        public Graph(int[][] childNodes) 
        {
            this.childNodes = childNodes;
        }

        public void DFSRecursive(int node, bool[] visited)
        {
            if (!visited[node])
            {
                visited[node] = true;
                Console.WriteLine(node);
                foreach (int childNode in childNodes[node])
                    DFSRecursive(childNode, visited);
            }
        }

        public void DFS(int node) 
        {
            bool[] visited = new bool[MaxNode];
            Stack<int> stack = new Stack<int>();
            stack.Push(node);
            visited[node] = true;
    

            while (stack.Count > 0)
            {
                int currentNode = stack.Pop();
                Console.WriteLine($"{currentNode } ");

                foreach (int childNode in childNodes[currentNode])
                {
                    if (!visited[childNode])
                    {
                        stack.Push(childNode);
                        visited[childNode] = true;
                    }
                }
            }
        }

        public void BFS(int startNode)
        {
            bool[] visited = new bool[MaxNode];
            Queue<int> queue = new Queue<int>();

            visited[startNode] = true;
            queue.Enqueue(startNode);

            while (queue.Count != 0)
            {
                int node = queue.Dequeue();
                Console.WriteLine(node);

                foreach (int childNode in childNodes[node])
                {
                    if (!visited[childNode])
                    {
                        visited[childNode] = true;
                        queue.Enqueue(childNode);
                    }
                }
            }
        }
    }
}
