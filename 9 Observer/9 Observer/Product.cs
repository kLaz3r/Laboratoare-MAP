using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Observer
{
    public class Product
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public int Count { get; }

        public Product(string name, string description, decimal price, int count)
        {
            Name = name;
            Description = description;
            Price = price;
            Count = count;
        }
    }
}
