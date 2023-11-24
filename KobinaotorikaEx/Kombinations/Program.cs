using System;

namespace Kombinations
{
    class Program
    {
        static int[] elements;
        static int[] kombi;

        public static void Combine(int index, int start)
        {
            if (index >= kombi.Length)
                Console.WriteLine("(" + string.Join(", ", kombi) + ")");
            else
                for (int i = start; i < elements.Length; i++)
                {
                        var currentElement = elements[i];
                        kombi[index] = currentElement;
                        Combine(index + 1, i + 1);
                }
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            elements = new int[n];
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                elements[i] = i + 1;
            kombi = new int[k];
            Combine(0, 0);
        }
    }
}
