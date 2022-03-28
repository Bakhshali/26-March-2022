using System;

namespace Practice.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            getFirstWords("Sir hemise shirdi");
           
        }

        public static void getFirstWords(string sentence)
        {
            string result = sentence.Substring(0, sentence.IndexOf(" "));
            Console.WriteLine(result);
        }
    }
}
