using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_State
{
    public class HasCoinState : State
    {
        public HasCoinState(VendingMachine vendingMachine) : base(vendingMachine) { }

        public override void InsertCoin()
        {
            Console.WriteLine("You can't insert another coin.");
        }

        public override void EjectCoin()
        {
            Console.WriteLine("Coin returned.");
            VendingMachine.UpdateState(new NoCoinState(VendingMachine));
        }

        public override void BuyProduct()
        {
            Console.WriteLine("Product bought.");
            VendingMachine.UpdateState(new SoldState(VendingMachine));
        }

        public override void Dispense()
        {
            Console.WriteLine("No product dispensed.");
        }
    }
}
