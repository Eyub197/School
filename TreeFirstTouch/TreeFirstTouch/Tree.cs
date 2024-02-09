using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeFirstTouch
{
    public class Tree<T>
    {
        private T value;
        private IList<Tree<T>> children;

        public T Value { get;  set; }
        public IList<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach( var chield in children)
            {
                this.Children.Add(chield);
            }
        }

        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.Value);
            foreach (var chield in this.Children)
            {
                chield.Print(indent + 1);
            }
        }

    }
}
