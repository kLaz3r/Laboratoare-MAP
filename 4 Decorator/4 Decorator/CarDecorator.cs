using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Decorator
{
    public class CarDecorator : ICar
    {
        protected ICar decoratedCar;

        public CarDecorator(ICar car)
        {
            decoratedCar = car;
        }

        public virtual void Assemble()
        {
            decoratedCar.Assemble();
        }

        public virtual decimal GetPrice()
        {
            return decoratedCar.GetPrice();
        }

        public virtual ECarType CarType => decoratedCar.CarType;
    }


}
