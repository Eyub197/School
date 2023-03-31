using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingExercisess
{
    class Program
    {
        static void Main(string[] args)
        {
            //1Напишете програма, която чете колекция от низове от конзолата и след това ги отпечатва
            //на конзолата.Всяко име трябва да бъде отпечатано на нов ред.Използвайте Action<T>
            List<string> names = Console.ReadLine().Split(' ').ToList();
            Action<string> namesInNewLine = (x) => Console.WriteLine(x);
            {
                foreach (var items in names)
                {
                    Console.WriteLine(items);
                }
            };

            //2Напишете програма, която чете колекция от имена като символни низове от
            //конзолата след това добавя "Sir" пред всяко име и го отпечатва обратно върху конзолата. Използвайте Action<T>

            //List<string>names = new List<string>();

            //Console.WriteLine("Enter some names (type 'end' to finish):");

            //while (true)
            //{
            //    string input = Console.ReadLine();

            //    if (input == "end")
            //    {
            //        break;
            //    }

            //    names.Add(input);
            //}

            //Action<string> printName = new Action<string>(name =>
            //{
            //    string sirName = "Sir " + name;
            //    Console.WriteLine(sirName);
            //});

            //Console.WriteLine("Sir names:");

            //foreach (string name in names)
            //{
            //    printName(name);
            //}

        }  
    }
}
