using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Decorator
{
    public class AmbianceDecorator : CarDecorator
    {
        public AmbianceDecorator(ICar car) : base(car) { }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding accessories for Ambiance model.");
        }

        public override decimal GetPrice()
        {
            return base.GetPrice() + 900;
        }

        public override ECarType CarType => ECarType.Ambiance;
    }

}
