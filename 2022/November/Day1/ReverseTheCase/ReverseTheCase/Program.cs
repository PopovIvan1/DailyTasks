using System;
using System.Linq;

namespace ReverseTheCase
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseCase("Happy Birthday"));
            Console.ReadLine();
        }

        public static string ReverseCase(string str)
        {
            return string.Concat(str.Select(ch => char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch)));
        }
    }
}
