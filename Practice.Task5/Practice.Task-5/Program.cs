using System;

namespace Practice.Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6,};

            getResize(ref array);

            
        }

        public static void getResize(ref int [] array)
        {
            Array.Resize(ref array, array.Length + 1);
            
            array[array.Length - 1] = 65;
           
            foreach (var item in array)
            {
                Console.WriteLine(item);    
            }        
           
        }
    }
}
