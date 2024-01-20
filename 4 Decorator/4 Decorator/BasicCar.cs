using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Decorator
{
    public class BasicCar : ICar
    {
        public ECarType CarType => ECarType.Basic;
        private decimal price = 7800;

        public void Assemble()
        {
            Console.WriteLine($"Assembling {CarType} car.");
        }

        public decimal GetPrice()
        {
            return price;
        }
    }
}
