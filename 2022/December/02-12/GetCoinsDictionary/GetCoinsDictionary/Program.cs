using System;
using System.Collections.Generic;

namespace GetCoinsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var coin in GetCoins(44))
            {
                Console.WriteLine($"{coin.Key}: {coin.Value}");
            }
            Console.ReadLine();
        }

        public static Dictionary<string, int> GetCoins(float number)
        {
            int numberToInt = (int)number;
            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                { "Nickels" , 0},
                { "Pennies" , 0},
                { "Dimes" , 0},
                { "Quarters" , 0}
            };

            if (number < 0) return result;
            while (numberToInt > 0)
            {
                if (numberToInt - 25 >= 0)
                {
                    numberToInt -= 25;
                    result["Quarters"] += 1;
                }
                else if (numberToInt - 10 >= 0)
                {
                    numberToInt -= 10;
                    result["Dimes"] += 1;
                }
                else if (numberToInt - 5 >= 0)
                {
                    numberToInt -= 5;
                    result["Nickels"] += 1;
                }
                else
                {
                    numberToInt -= 1;
                    result["Pennies"] += 1;
                }
            }

            return result;
        }
    }
}
