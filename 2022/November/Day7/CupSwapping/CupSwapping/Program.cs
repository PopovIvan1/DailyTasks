using System;
using System.Linq;

namespace CupSwapping
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(CupSwapping(new[] { "AB", "CA", "AB" }));
            Console.ReadLine();
        }

        public static string CupSwapping(string[] swaps)
        {
            return swaps.Aggregate("B",(curr, move) =>
                  move.Contains(curr) ? move.Replace(curr, "") : curr);
        }
    }
}
