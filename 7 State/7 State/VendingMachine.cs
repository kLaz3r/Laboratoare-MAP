using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_State
{
    public class VendingMachine
    {
        private State currentState;
        private int productCount = 5;

        public VendingMachine()
        {
            currentState = new NoCoinState(this);
        }

        public void UpdateState(State state)
        {
            currentState = state;
        }

        public bool IsEmpty()
        {
            return productCount == 0;
        }

        private void InsertCoin()
        {
            currentState.InsertCoin();
        }

        private void EjectCoin()
        {
            currentState.EjectCoin();
        }

        private void BuyProduct()
        {
            currentState.BuyProduct();
            currentState.Dispense();
        }

        private void ReFill()
        {
            productCount = 5;
            Console.WriteLine("Machine refilled with products.");
        }

        private void Inspect()
        {
            Console.WriteLine($"Product count: {productCount}");
        }
        public void ReleaseProduct()
        {
            Console.WriteLine("Product released.");
            productCount--;
        }

        public void Run()
        {
            Console.WriteLine("Vending Machine Simulator");

            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Insert Coin");
                Console.WriteLine("2. Eject Coin");
                Console.WriteLine("3. Buy Product");
                Console.WriteLine("4. Refill Machine");
                Console.WriteLine("5. Inspect Machine");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InsertCoin();
                        break;
                    case 2:
                        EjectCoin();
                        break;
                    case 3:
                        BuyProduct();
                        break;
                    case 4:
                        ReFill();
                        break;
                    case 5:
                        Inspect();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
