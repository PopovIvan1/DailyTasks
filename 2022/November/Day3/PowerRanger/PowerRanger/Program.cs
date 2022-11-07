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
            int maxNumber = (int)Math.Pow(max, (double)1 / power);
            int minNumber = (int)Math.Pow(min, (double)1 / power);
            int border = 0;
            if ((min == (int)Math.Pow(minNumber, power)) && (max == (int)Math.Pow(maxNumber, power))) border++;
            return maxNumber - minNumber + border;
        }
    }
}
