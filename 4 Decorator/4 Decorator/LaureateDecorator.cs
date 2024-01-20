using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Decorator
{
    public class LaureateDecorator : CarDecorator
    {
        public LaureateDecorator(ICar car) : base(car) { }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding accessories for Laureate model.");
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 1100;
        }

        public override ECarType CarType => ECarType.Laureate;
    }

}
