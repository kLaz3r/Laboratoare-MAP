using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Flyweight
{
    public class CardMoney : Money
    {
        public override decimal TotalCacheValue => 0;
        public override string GetMoneyType() => "Card";
    }
}
