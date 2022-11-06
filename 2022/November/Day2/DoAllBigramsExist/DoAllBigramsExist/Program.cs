using System;
using System.Linq;

namespace DoAllBigramsExist
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(CanFind(new string[] { "at", "be", "th", "au" }, new string[] { "beautiful", "the", "hat" }).ToString());
            Console.ReadLine();
        }

        public static bool CanFind(string[] bigrams, string[] words)
        {
            string wordsToStr = string.Join(" ", words);
            int findCount = bigrams.Where(bigram => wordsToStr.Contains(bigram)).Count();
            return findCount == bigrams.Length;
        }
    }
}
