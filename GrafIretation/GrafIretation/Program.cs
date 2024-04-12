using System;

namespace GrafIretation
{
    class Program
    {
        static void Main(string[] args)
        {
			Graph g = new Graph(new int[][] {
			new int[] {3, 6}, // наследници на връх 0
			new int[] {2, 3, 4, 5, 6}, // наследници на връх 1
			new int[] {1, 4, 5}, // наследници на връх 2
			new int[] {0, 1, 5}, // наследници на връх 3
			new int[] {1, 2, 6}, // наследници на връх 4
			new int[] {1, 2, 3}, // наследници на връх 5
			new int[] {0, 1, 4}  // наследници на връх 6
			});

			bool[] vis = new bool[g.MaxNode];
            Console.WriteLine($"BFS: ");
			g.BFS(0);
            Console.WriteLine("DFS: ");


            Console.WriteLine("DFS recursive: ");
			g.DFSRecursive(0, vis);
		}
	}
}
