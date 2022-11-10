using System;
using System.Linq;

namespace SockPairs
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(SockPairs("hello world"));
            Console.ReadLine();
        }

        public static int SockPairs(string socks)
        {
            return socks.ToCharArray().GroupBy(c => c).Select(c => c.Count() / 2).Sum();
        }
    }
}
