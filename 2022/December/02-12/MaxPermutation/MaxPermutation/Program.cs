using System;
using System.Linq;

namespace MaxPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxPermution(155444510));
            Console.ReadLine();
        }

        public static int GetMaxPermution(int number)
        {
            return number < 0 ? number :
                int.Parse(string.Concat(number.ToString().ToArray().OrderBy(x => -x)));
        }
    }
}
