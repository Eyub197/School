using System;

namespace TreeFirstTouch
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(7,
                new Tree<int>(15,
                    new Tree<int>(12),
                    new Tree<int>(2),
                    new Tree<int>(22)),
                new Tree<int>(13,
                    new Tree<int>(5,
                    new Tree<int>(23))),
                new Tree<int>(24)
                ); 

            tree1.Print();
        }
    }
}
