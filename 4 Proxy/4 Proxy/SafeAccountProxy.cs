using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Proxy
{
    public class SafeAccountProxy : IAccountProxy
    {
        private IAccount account;
        private string password;

        public SafeAccountProxy()
        {
            account = new Account();
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        private bool Authenticate(string enteredPassword)
        {
            return enteredPassword == password;
        }

        public void Deposit(decimal amount)
        {
            if (AuthenticatePassword())
            {
                account.Deposit(amount);
            }
        }

        public void Withdraw(decimal amount)
        {
            if (AuthenticatePassword())
            {
                account.Withdraw(amount);
            }
        }

        public void DisplayBalance()
        {
            if (AuthenticatePassword())
            {
                account.DisplayBalance();
            }
        }

        private bool AuthenticatePassword()
        {
            Console.Write("Enter password: ");
            string enteredPassword = Console.ReadLine();

            if (Authenticate(enteredPassword))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect password. Access denied.");
                return false;
            }
        }
    }
}
