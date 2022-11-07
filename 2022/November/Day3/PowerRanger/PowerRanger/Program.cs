using System;
using System.Linq;

namespace PowerRanger
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(PowerRanger(2, 49, 65));
            Console.ReadLine();
        }

        public static int PowerRanger(int power, int min, int max)
        {
            return (int)(Math.Pow(max, (double)1 / power) - Math.Pow(min, (double)1 / power)) + 1;
        }
    }
}
