using System;

namespace MaxSubstring
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(findMaxSubstr(new[] { "hello world" , "hello"}));
            Console.ReadLine();
        }

        public static string findMaxSubstr(string[] arr)
        {
            int n = arr.Length;

            string str = arr[0];
            int len = str.Length;

            string res = "";

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j <= len; j++)
                {
                    string stem = str.Substring(i, j - i);
                    int k;
                    for (k = 1; k < n; k++)
                        if (!arr[k].Contains(stem))
                            break;

                    if (k == n && res.Length < stem.Length)
                        res = stem;
                }
            }

            return res;
        }
    }
}
