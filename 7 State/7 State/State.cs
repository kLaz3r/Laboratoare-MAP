using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_State
{
    public abstract class State
    {
        protected VendingMachine VendingMachine;

        public State(VendingMachine vendingMachine)
        {
            VendingMachine = vendingMachine;
        }

        public abstract void InsertCoin();
        public abstract void EjectCoin();
        public abstract void BuyProduct();
        public abstract void Dispense();
    }

}
