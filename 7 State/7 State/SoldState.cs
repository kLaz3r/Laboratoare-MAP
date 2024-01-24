using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_State
{
    public class SoldState : State
    {
        public SoldState(VendingMachine vendingMachine) : base(vendingMachine) { }

        public override void InsertCoin()
        {
            Console.WriteLine("Please wait, product dispensing.");
        }

        public override void EjectCoin()
        {
            Console.WriteLine("Sorry, you already turned the crank.");
        }

        public override void BuyProduct()
        {
            Console.WriteLine("You already bought a product.");
        }

        public override void Dispense()
        {
            VendingMachine.ReleaseProduct();
            if (VendingMachine.IsEmpty())
            {
                VendingMachine.UpdateState(new SoldOutState(VendingMachine));
            }
            else
            {
                VendingMachine.UpdateState(new NoCoinState(VendingMachine));
            }
        }
    }
}
