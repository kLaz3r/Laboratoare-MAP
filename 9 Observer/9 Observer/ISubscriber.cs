using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Observer
{
    public interface ISubscriber
    {
        string Name { get; }
        void Update(List<Product> newProducts);
    }
}
