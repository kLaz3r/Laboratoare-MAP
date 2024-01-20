using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Visitor
{
    public class ReportVisitor : IVisitor
    {
        private int totalCustomers = 0;
        private int totalInvoices = 0;
        private int totalProductsSold = 0;
        private decimal totalValueSold = 0;

        public void Visit(Product product)
        {
            totalProductsSold++;
            totalValueSold += product.Price;
        }

        public void Visit(Customer customer)
        {
            totalCustomers++;
            totalInvoices++;
        }

        public void DisplayReport()
        {
            Console.WriteLine("Supermarket Report:");
            Console.WriteLine($"- Total customers: {totalCustomers}");
            Console.WriteLine($"- Total invoices issued: {totalInvoices}");
            Console.WriteLine($"- Total products sold: {totalProductsSold}");
            Console.WriteLine($"- Total value of products sold: {totalValueSold} lei");
        }

        void IVisitor.Visit(Product product)
        {
            throw new NotImplementedException();
        }

        void IVisitor.Visit(Order order)
        {
            throw new NotImplementedException();
        }

        void IVisitor.Visit(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
