using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount you would like to convert to coins:");
            var cents = Math.Floor(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine($"{cents} cents is equal to...");

            var goldValue = 10;
            var silverValue = 5;

            var goldCoins = Math.Floor(cents / goldValue);
            var remainder = cents % goldValue;

            var silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}