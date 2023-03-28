using System;
using System.Linq;
using System.Threading;

namespace AnotherSinhThreadsExercises
{
    class Program
    {
        static object lockObject = new object();

        static void Run()
        {
            lock (lockObject)
            {
                string [] favoritAnimls = Console.ReadLine().Split(' ').ToArray();

                for (int i = 0; i < favoritAnimls.Length; i++)
                {
                    Console.WriteLine($"{favoritAnimls[i]}");
                    Thread.Sleep(1000);
                }
            }
           
        }
        

        static void Main(string[] args)
        {
            Thread thread = new Thread(Run);
            Thread thread1 = new Thread(Run);

            thread.Start();
            thread1.Start();

        }
    }
}

/*
  1.	Създайте  обект за заключване locked , който може да се използва от множество нишки за синхронизиране на достъпа до текст .
2.	Метод Run(), в който: 
•	Блокирате обекта 
•	Въвеждате текст в масив
•	Извеждате текста дума по дума на отделни редове.
3.	Свържете две дъщерни нишки с метода и стартирайте нишките

 
 */