using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Task6
{
    internal class Book : Product
    {
        public string AuthorName;
        public int PageCount;

        public Book(string name, int price, int count,string authorName, int pageCount):base(name, price, count)
        {
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {
            if (Count >= 1)
            {
                Count--;

                TotalInCome += Price; 

                Console.WriteLine(Count);
            }

            else
            {
                Console.WriteLine("Unsuccess sale");
            }
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Count: {Count}, Total: {TotalInCome}, Author: {AuthorName}, PageCount: {PageCount}");
        }

    }
}
