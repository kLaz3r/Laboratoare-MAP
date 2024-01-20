using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Proxy
{
    public class Account : IAccount
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount} UM");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount} UM");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {balance} UM");
        }
    }
}
