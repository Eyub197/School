using System;
using System.Threading;

namespace ExNishki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваведете числоо!");
            
            Thread tr1 = new Thread(Factoriel);
            tr1.Start();
            Thread tr2 = new Thread(Dfactoriel);
            tr2.Start();

        }

        public static void Factoriel()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Дъщерната нишка1 започна");
            int result = 1;
            for (int i = number; i > 1; i--)
            {
                result *= i;
            }
            Console.WriteLine("Нишката завърши1");
            Console.WriteLine($"Резултата е {result}");
            
        }

        public static void Dfactoriel()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Нишка 2 започма");
            int result = 1;
            for (int i = number; i <=1; i =-2)
            {
                result = result * i;
            }
            Console.WriteLine("Нишка2 завърши");
            Console.WriteLine($"{result}");
        }
    }
}
