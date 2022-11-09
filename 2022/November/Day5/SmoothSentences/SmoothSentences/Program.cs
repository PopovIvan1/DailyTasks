using System;

namespace SmoothSentences
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(IsSmooth("She eats super righteously"));
            Console.ReadLine();
        }

        public static bool IsSmooth(string sentence)
        {
            string[] words = sentence.ToLower().Split(' ');
            for (int i = 0; i < words.Length - 1; i++)
                if (words[i][words[i].Length - 1] != words[i + 1][0])
                    return false;
            return true;
        }
    }
}
