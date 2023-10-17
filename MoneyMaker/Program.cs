using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount you would like to convert to coins:");
            double cents = Math.Floor(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine($"{cents} cents is equal to...");

            int goldValue = 10;
            int silverValue = 5;

            double goldCoins = Math.Floor(cents / goldValue);
            double remainder = cents % goldValue;

            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}