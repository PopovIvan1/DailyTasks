using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayOfMultiples
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ", ArrayOfMultiples(4, 7)));
            Console.WriteLine(string.Join(" ", Enumerable.Range(1, 7).ToArray()));
            Console.ReadLine();
        }

        public static int[] ArrayOfMultiples(int num, int length)
        {
            return Enumerable.Range(1, length).Select(x => x * num).ToArray();
        }
    }
}
