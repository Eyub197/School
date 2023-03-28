using System;
using System.Threading;

namespace SinhronaizingThreadsExercises
{
    class Program
    {
        static object lockObject = new object();

        static void Count() {
            lock(lockObject)
           //в and б lock (lockObject) 
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Брояча е на{i}");
                }
            }
        }
        static void Main(string[] args)
        {
            Thread child1= new Thread(Count);
            Thread child2 = new Thread(Count);
            //в Thread child3 = new Thread(Count);
            child1.Start();
            child2.Start();
            //в child3.Start();
        }
    }
}

/*
 А)
-Създайте  обект за заключване lockObject , който може да се използва от множество нишки за синхронизиране на достъпа до брояч.
static object lockObject = new object();
-Метод Count(), в който: 
Блокирате обекта и стартирате   цикъл for за извеждане стойността на брояч от 1 до 10
-Свържете две дъщерни нишки с метода и стартирайте нишките
B) Решете задачата  с достъп на  нишкте до обект  без блокиране на обекта 
C) Решете задачата  с достъп на  повече от две нишки  до обект  /със ,без блокиране на обекта/ 
 */