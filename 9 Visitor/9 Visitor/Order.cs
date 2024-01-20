using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Visitor
{
    public class Order : IVisitable
    {
        public List<Product> Products { get; }

        public Order(List<Product> products)
        {
            Products = products;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
