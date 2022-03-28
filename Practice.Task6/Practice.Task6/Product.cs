using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Task6
{
    abstract class Product
    {
        
        public string Name;
        public int Price;
        public int Count;
        public int TotalInCome;

        public Product(string name, int price, int count)
        {
            
            Name = name;
            Price = price;
            Count = count;
        }
        

        public abstract void Sell();


        public abstract void ShowInfo();




    }
}
