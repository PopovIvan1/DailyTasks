using System;
using System.Linq;

namespace ImaginaryCodingInterview
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120));
            Console.ReadLine();
        }

        public static string Interview(int[] arr, int tot)
        {
            var timeLimits = new int[] { 5, 5, 10, 10, 15, 15, 20, 20 };
            return arr.Zip(timeLimits, (a, b) => a <= b).Count(s => s) == 8 && tot <= 120
                ? "qualified"
                : "disqualified";
        }
    }
}
