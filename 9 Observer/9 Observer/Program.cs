using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Observer
{
    internal class Program
    {
        static void Main()
        {
            OnlineStore onlineStore = new OnlineStore();

            ISubscriber subscriber1 = new Subscriber("Subscriber1");
            ISubscriber subscriber2 = new Subscriber("Subscriber2");

            onlineStore.Subscribe(subscriber1);
            onlineStore.Subscribe(subscriber2);

            List<Product> newProducts = new List<Product>
        {
            new Product("Laptop", "Powerful laptop", 4500, 10),
            new Product("Smartphone", "Latest smartphone model", 2000, 20),
            new Product("Headphones", "High-quality headphones", 500, 30)
        };

            onlineStore.Inventory(newProducts);

            Console.WriteLine($"Total value of inventory: {onlineStore.GetTotalValue()} lei");
        }
    }
}
