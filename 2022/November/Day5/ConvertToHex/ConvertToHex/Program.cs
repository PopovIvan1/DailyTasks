using System;
using System.Linq;

namespace ConvertToHex
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToHex("hello world"));
            Console.ReadLine();
        }

        public static string ConvertToHex(string inputword)
        {
            return string.Join(" ", inputword.Select(ch => ((int)ch).ToString("x2")));
        }
    }
}
