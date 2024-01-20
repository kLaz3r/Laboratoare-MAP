using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Flyweight
{
    public class CashRegister
    {
        private List<Money> cashInRegister = new List<Money>();

        public void CacheIn(Money money)
        {
            cashInRegister.Add(money);
            Console.WriteLine($"Received: {money.GetMoneyType()}");
        }

        public void CacheOut()
        {
            decimal totalCache = 0;

            foreach (var money in cashInRegister)
            {
                totalCache += money.TotalCacheValue;
            }

            Console.WriteLine($"Total cache value: {totalCache} lei");
        }
    }
}
