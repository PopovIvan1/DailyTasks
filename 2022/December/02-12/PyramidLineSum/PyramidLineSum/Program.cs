using System;
using System.Linq;

namespace PyramidLineSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetRowSum(5));
            Console.ReadLine();
        }

        public static int GetRowSum(int index)
        {
            return index < 1 ? 0 :
                Enumerable.Range(index * (index - 1) + 1, index * 2)
                .Where(x => x % 2 == 1).Sum();
        }
    }
}
