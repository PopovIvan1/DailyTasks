using System;
using System.Text.RegularExpressions;

namespace CensoredStrings
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(Uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
            Console.ReadLine();
        }

        public static string Uncensor(string txt, string vowels)
        {
            var i = 0;
            return Regex.Replace(txt, @"\*", _ => vowels[i++].ToString());
        }
    }
}
