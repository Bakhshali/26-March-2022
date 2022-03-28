using System;

namespace Practice.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(getValue());

        }


        public static bool getValue()
        {
            string sentence = "Bu1";

            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            foreach (var item in sentence)
            {

                if (char.IsDigit(item))
                {
                    hasDigit = true;
                    continue;
                }

                if (char.IsUpper(item))
                {
                    hasUpper = true;
                    continue;
                }

                if (char.IsLower(item))
                {
                    hasLower = true;
                    
                }              
            }
            bool result = hasLower && hasDigit && hasUpper;

            return result;
        }
    }
}
