using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Decorator
{
    public class AccesDecorator : CarDecorator
    {
        public AccesDecorator(ICar car) : base(car) { }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding accessories for Acces model.");
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 700;
        }

        public override ECarType CarType => ECarType.Acces;
    }

}
