using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Decorator
{
    public interface ICar
    {
        ECarType CarType { get; }
        void Assemble();
        decimal GetPrice();
    }

}
