using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>(7,
                new Tree<int>(19,
                    new Tree<int>(1),
                    new Tree<int>(12),
                    new Tree<int>(21)),
                new Tree<int>(21),
                new Tree<int>(21,
                    new Tree<int>(23),
                    new Tree<int>(6)));  

            tree.Print();
            Console.WriteLine($"Koren : {tree.BFS().First()}");

            List<int> treeValues = tree.BFS().ToList();
            Console.WriteLine(string.Join(" ", treeValues));

            Console.WriteLine($"Broi vasli : {treeValues.Count()}");

            Console.WriteLine("Vavedete vazel za tarsene na sreshtane");
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            foreach (var item in treeValues)
            {         
                if (item == number)
                {
                    count++;
                }
            }
            Console.WriteLine($"Broi vasli sas stoinost {number} se sresta {count} pati ");

        }
    }
}
