using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funct_Landa_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(45, "Ivan Ivanov", 765.56);
            Person p2 = new Person(35, "Stojan Dimov", 1365.6);
            Person p3 = new Person(65, "Kiril Marinov", 1765.56);
            Person p4 = new Person(59, "Kosta Kamenov", 985.56);
            Person p5 = new Person(35, "Anton Dimov", 1065.6);

            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5 };

            //1.	Каква е най-високата заплата във фирмата
            var maxSalary = people.Max(x => x.Salary);
            Console.WriteLine($"Най-високата заплата {maxSalary}");

            //2.	На колко години е най-младият работник във фирмата
            var youngestEmployess = people.Min(x => x.Age);
            Console.WriteLine($"Най-малдия работник {youngestEmployess}");

            //3.	Каква е сумата за заплати на цялата фирма
            var sumSalary = people.Sum(x => x.Salary);
            Console.WriteLine($"Заплатите {sumSalary}");

            //4.	Каква е средната заплата във фирмата
            var AvgSalary = people.Average(x => x.Salary);
            Console.WriteLine($"Средна заплата {AvgSalary}");

            //5.	*Каква е средната възраст на работниците във фирмата
            var AvgAge = people.Average(x => x.Age);
            Console.WriteLine($"Средна възраст {AvgAge}");

            Console.WriteLine();
            //6.	Изведете списък с работниците по азбучен ред 
            List<Person> people1 = people.OrderBy(x => x.Name).ToList();
            foreach (var item in people1)
            {
                Console.WriteLine(item.ToString());
            }

            //7.	Изведете списък с работниците сортирани по възраст в намаляващ ред и по заплата в нарастваш ред

            Console.WriteLine();
            List<Person> people2 = people.OrderByDescending(x => x.Age).ThenBy(x => x.Salary).ToList();
            foreach (var item in people2)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            //8.	*Изведете списък с работниците сортирани по възраст в намаляващ ред и по заплата в намаляващ ред 
            List<Person> people3 = people.OrderByDescending(x => x.Age).ThenByDescending(x => x.Salary).ToList();
            foreach (var item in people2)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();

            //9.	Изведете  списък с работниците със заплати над средната
            people = people.Where(x => x.Salary > people.Average(e => e.Salary)).ToList();
            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }

            //10.	Изведете списък с работниците с трите най-високи заплати във фирмата
            Console.WriteLine();

            people = people.OrderByDescending(x => x.Salary).Take(3).ToList();
            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
