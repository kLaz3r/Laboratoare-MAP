using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Flyweight
{
    public class CoinMoney : Money
    {
        private decimal value;

        public CoinMoney(decimal value)
        {
            this.value = value;
        }

        public override decimal TotalCacheValue => value;
        public override string GetMoneyType() => $"Coin ({value} bani)";
    }
}
