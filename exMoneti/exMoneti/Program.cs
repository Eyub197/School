using System;
using System.Collections.Generic;

namespace exMoneti
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalSum = 15;
            int currentSum = 0;
            int[] coins = { 10, 10, 5, 5, 2, 2, 1, 1 };
            int coinsCount = 0;
            Queue<int> resultCoins = new Queue<int>();

            for (int i = 0; i < coins.Length; i++) 
            {
                if (currentSum + coins[i] > finalSum) continue;
                currentSum += coins[i];
                coinsCount++;
                
                resultCoins.Enqueue(coins[i]);
                if (currentSum == finalSum)
                {
                    Console.WriteLine("Found the sum");
                    Console.WriteLine("Coinst we used" + string.Join(", ", resultCoins));
                }
            }
            Console.WriteLine($"The sum is {coinsCount}");

     
        }
    }
}
