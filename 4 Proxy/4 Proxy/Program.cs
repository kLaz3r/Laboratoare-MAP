using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Proxy
{
    internal class Program
    {
        static void Main()
        {
            IAccountProxy accountProxy = new SafeAccountProxy();
            accountProxy.SetPassword("securepassword");

            accountProxy.Deposit(1000);
            accountProxy.Withdraw(500);

            Console.WriteLine("Displaying balance after authentication:");
            accountProxy.DisplayBalance();
        }
    }
}
