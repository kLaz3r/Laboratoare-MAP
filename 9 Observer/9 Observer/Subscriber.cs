using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Observer
{
    public class Subscriber : ISubscriber
    {
        public string Name { get; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Update(List<Product> newProducts)
        {
            Console.WriteLine($"{Name} received notification about new products:");

            foreach (var product in newProducts)
            {
                Console.WriteLine($"- {product.Name} ({product.Price} lei)");
            }
        }
    }
}
