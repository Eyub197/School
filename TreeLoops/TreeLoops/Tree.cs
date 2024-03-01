using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLoops
{
    public class Tree<T>
    {
        private T value;
        private IList<Tree<T>> children;

        public T Value { get; set; }
        public Tree<T> Parent { get; set; }
        public IList<Tree<T>> Children { get; set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach (var child in children)
            {
                this.Children.Add(child);
            }
        }

        public void Print( int indent = 0 )
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.Value);
            foreach (var child in this.Children)
                child.Print(indent + 1);
        }

        private void DFS(Tree<T> tree, List<T> order)
        {
            foreach (var child in this.Children)
                this.DFS(child, order);
            order.Add(tree.Value);
        }
        public IEnumerable<T> OrderDFS()
        {
            List<T> order = new List<T>();
            this.DFS(this, order);
            return order;
        }

        public IEnumerable<T> BFS()
        {
            List<T> order = new List<T>();
            Queue<Tree<T>> visited = new Queue<Tree<T>>();
            visited.Enqueue(this);
            while (visited.Count > 0)
            {
                var next = visited.Dequeue();
                order.Add(next.Value);
                foreach (var child in next.Children)
                    visited.Enqueue(child);
            }
            return order;
        }
        
    }
}
