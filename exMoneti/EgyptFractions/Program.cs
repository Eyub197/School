using System;
using System.IO;
using System.Collections.Generic;
namespace EgyptFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter p sir : ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter q sir : ");
            int q = int.Parse(Console.ReadLine());
            Fraction goalFractiom = new Fraction(p, q);
            Fraction currentFraction = new Fraction(0, 1);
            Queue<Fraction> fraction = new Queue<Fraction>();
        
            int part = 2;
            while(!(currentFraction.Numerator == goalFractiom.Numerator && currentFraction.Denominator == goalFractiom.Denominator))
            {
                var nextFraction = new Fraction(1, part);
                if(currentFraction + nextFraction < goalFractiom) 
                {
                    fraction.Enqueue(nextFraction);
                    currentFraction += nextFraction;
                }
                part++;
            }

            Console.WriteLine(string.Join(", ", fraction));
        }
    }
}
