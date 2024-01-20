using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Flyweight
{
    public abstract class Money
    {
        public abstract decimal TotalCacheValue { get; }
        public abstract string GetMoneyType();
    }
}
