using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_State
{
    public class NoCoinState : State
    {
        public NoCoinState(VendingMachine vendingMachine) : base(vendingMachine) { }

        public override void InsertCoin()
        {
            Console.WriteLine("You inserted a coin.");
            VendingMachine.UpdateState(new HasCoinState(VendingMachine));
        }

        public override void EjectCoin()
        {
            Console.WriteLine("You haven't inserted a coin.");
        }

        public override void BuyProduct()
        {
            Console.WriteLine("You need to insert a coin first.");
        }

        public override void Dispense()
        {
            Console.WriteLine("You need to buy a product first.");
        }
    }
}
