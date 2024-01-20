using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Observer
{
    public class OnlineStore : IOnlineStore
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        private List<Product> inventory = new List<Product>();

        public void Subscribe(ISubscriber subscriber)
        {
            if (!subscribers.Contains(subscriber))
            {
                subscribers.Add(subscriber);
                Console.WriteLine($"{subscriber.Name} subscribed to the online store.");
            }
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            if (subscribers.Contains(subscriber))
            {
                subscribers.Remove(subscriber);
                Console.WriteLine($"{subscriber.Name} unsubscribed from the online store.");
            }
        }

        public void Notify(List<Product> newProducts)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Update(newProducts);
            }
        }

        public void Inventory(List<Product> products)
        {
            inventory.AddRange(products);
            Notify(products);
        }

        public decimal GetTotalValue()
        {
            decimal totalValue = 0;

            foreach (var product in inventory)
            {
                totalValue += product.Price * product.Count;
            }

            return totalValue;
        }
    }
}
