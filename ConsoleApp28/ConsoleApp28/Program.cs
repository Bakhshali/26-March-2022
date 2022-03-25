using System;
using System.Reflection;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(isOdd(11));

            Console.WriteLine(isEven(11));
        }

       
        public static bool isOdd(int num1)
        {
            return num1 % 2 == 1;
        }

        public static bool isEven(int num1)
        {
            return num1 % 2 == 0;
          
        }
    }
}

