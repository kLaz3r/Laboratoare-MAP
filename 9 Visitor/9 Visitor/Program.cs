using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Visitor
{
    internal class Program
    {
        static void Main()
        {
            List<IVisitable> items = new List<IVisitable>
        {
            new Product("Apple", 2.5m),
            new Product("Milk", 3.0m),
            new Order(new List<Product>
            {
                new Product("Bread", 1.8m),
                new Product("Eggs", 5.0m)
            }),
            new Customer(new List<Order>
            {
                new Order(new List<Product>
                {
                    new Product("Chocolate", 4.0m),
                    new Product("Coffee", 6.5m)
                }),
                new Order(new List<Product>
                {
                    new Product("Juice", 3.0m),
                    new Product("Chips", 2.0m)
                })
            })
        };

            SupermarketReport reportVisitor = new SupermarketReport();

            foreach (var item in items)
            {
                item.Accept(reportVisitor);
            }

            reportVisitor.DisplayReport();
        }
    }
}
