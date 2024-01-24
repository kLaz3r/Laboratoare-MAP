using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_State
{
    public class SoldOutState : State
    {
        public SoldOutState(VendingMachine vendingMachine) : base(vendingMachine) { }

        public override void InsertCoin()
        {
            Console.WriteLine("Sorry, the machine is sold out.");
        }

        public override void EjectCoin()
        {
            Console.WriteLine("You can't eject, you haven't inserted a coin yet.");
        }

        public override void BuyProduct()
        {
            Console.WriteLine("Sorry, the machine is sold out.");
        }

        public override void Dispense()
        {
            Console.WriteLine("No product to dispense.");
        }
    }

}
