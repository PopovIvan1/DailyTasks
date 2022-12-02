using System;
using System.IO;

namespace FirstNotEmptyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFirstNotEmptyString("input.txt"));
            Console.ReadLine();
        }

        public static string GetFirstNotEmptyString(string fileName)
        {
            string result = "";
            using (StreamReader sr = new StreamReader(fileName))
            {
                while ((result = sr.ReadLine()) != null)
                    if (result != "") break; 
            }
            return result != null ? result : "";
        }
    }
}
