using System;
using System.Linq;

namespace RecursiveDigitsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDigitsSum(1233));
            Console.ReadLine();
        }

        public static int GetDigitsSum(int number)
        {
            if (number < 1) return number;
            int result = number.ToString().ToArray().Sum(x => int.Parse(x.ToString()));
            return result < 10 ? result : GetDigitsSum(result);
        }
    }
}
