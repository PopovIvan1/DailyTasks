using System;
using System.Linq;

namespace ReverseAndNot
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseAndNot(3456));
            Console.ReadLine();
        }

        public static string ReverseAndNot(int i)
        {
            return new string(i.ToString().Reverse().ToArray()) + i;
        }
    }
}
