using System;
using System.Linq;

namespace ConsecutiveNumbers
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(Cons(new[] { 5, 1, 4, 3, 2 }));
            Console.ReadLine();
        }

        public static bool Cons(int[] arr)
        {
            Array.Sort(arr);
            int curVal = arr[0] - 1;
            return arr.All(x => x == ++curVal);
        }
    }
}
