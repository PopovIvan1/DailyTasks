using System;

namespace ReverseCoding
{
    class Program
    {
        /// <summary>
        /// Function usage example.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine(MysteryFunc("A10B5C2"));
            Console.ReadLine();
        }

        public static string MysteryFunc(string str)
        {
            char state = str[0];
            int repeat = 0;
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9') repeat = repeat * 10 + int.Parse(str[i].ToString());
                else
                {
                    result += new string(state, repeat);
                    state = str[i];
                    repeat = 0;
                }
            }
            result += new string(state, repeat);

            return result;
        }
    }
}
