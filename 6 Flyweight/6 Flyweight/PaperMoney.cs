using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Flyweight
{
    public class PaperMoney : Money
    {
        private decimal value;

        public PaperMoney(decimal value)
        {
            this.value = value;
        }

        public override decimal TotalCacheValue => value;
        public override string GetMoneyType() => $"Paper Money ({value} lei)";
    }
}
