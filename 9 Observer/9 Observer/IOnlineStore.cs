using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Observer
{
    public interface IOnlineStore
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void Notify(List<Product> newProducts);
        void Inventory(List<Product> products);
        decimal GetTotalValue();
    }
}
