using System;

namespace Varitations
{
    class Program
    {
        static int[] elements;
        static bool[] used;
        static int[] vari;

        public static void Variation(int index)
        {
            if (index >= vari.Length)
                Console.WriteLine("(" + string.Join(", ", vari) + ")");

            else
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!used[i])
                    {
                        var currentElement = elements[i];
                        used[i] = true;
                        vari[index] = currentElement;
                        Variation(index + 1);
                        used[i] = false;
                    }
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
            used = new bool[elements.Length];
            vari = new int[k];
            Variation(0);
        }
    }
}
