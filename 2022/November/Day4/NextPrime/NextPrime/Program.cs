using System;
using System.Linq;

namespace NextPrime
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(NextPrime(34));
            Console.ReadLine();
        }

        public static int NextPrime(int num)
        {
            return Enumerable.Range(2, (int)Math.Sqrt(num) + 1).All(x => num % x != 0) ? num : NextPrime(num + 1);
        }
    }
}
