using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Visitor
{
    public class Customer : IVisitable
    {
        public List<Order> Orders { get; }

        public Customer(List<Order> orders)
        {
            Orders = orders;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
