using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Flyweight
{
    internal class Program
    {
        static void Main()
        {
            CashRegister cashRegister = new CashRegister();

            Money cardMoney = new CardMoney();
            Money coinMoney1 = new CoinMoney(10);
            Money coinMoney2 = new CoinMoney(5);
            Money paperMoney = new PaperMoney(100);

            cashRegister.CacheIn(cardMoney);
            cashRegister.CacheIn(coinMoney1);
            cashRegister.CacheIn(coinMoney2);
            cashRegister.CacheIn(paperMoney);

            cashRegister.CacheOut();
        }
    }
}
