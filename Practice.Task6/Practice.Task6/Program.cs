using System;

namespace Practice.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("A Brief History of Time", 50, 9, "Cosmology", 256);

            
            Console.WriteLine("Sale by Stephan Hawking's books:");
            book.ShowInfo() ;

            Console.WriteLine("The rest of the book:");
            book.Sell();
            Console.WriteLine("The Budget");
            Console.WriteLine(book.TotalInCome);
           
            Console.WriteLine("The rest of the book:");
            book.Sell();
            Console.WriteLine("The Budget");            
            Console.WriteLine(book.TotalInCome);


            Console.WriteLine("\n     \n");
            
            Book book1 = new Book("The Grand Design", 60, 10, "Theoretical Physics", 224);

            
            Console.WriteLine("Sale by Stephan Hawking's books:");
            book.ShowInfo();

            Console.WriteLine("The rest of the book:");
            book.Sell();
            Console.WriteLine("The Budget");
            Console.WriteLine(book.TotalInCome);

            Console.WriteLine("The rest of the book:");
            book.Sell();
            Console.WriteLine("The Budget");
            Console.WriteLine(book.TotalInCome);

        }
    }
}
