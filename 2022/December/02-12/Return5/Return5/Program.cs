using System;

namespace Return5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Get5());
            Console.ReadLine();
        }

        public static int Get5()
        {
            return (new int[] { 'a', 'a', 'a', 'a', 'a' }).Length;
        }
    }
}
