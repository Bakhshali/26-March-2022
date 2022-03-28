using System;

namespace Practice.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(Check());



        }

        public static bool Check()
        {
            string words = "bu gun";
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsUpper(words[i]))
                {
                    count++;
                }
                else if (char.IsWhiteSpace(words[i]))
                {
                    count++;
                    if (char.IsUpper(words[i + 1]))
                    {
                        count++;
                        return true;
                    }
                    if(words[i] == ' ' && i == words.Length - 1)
                    {
                        count++;
                        return true;
                    }
                }
            }
            return false;
       }
    }
}
