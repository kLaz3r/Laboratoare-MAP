using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builderr
{
    public class CarBuilder : ICarBuilder
    {
        private Car car = new Car();

        public void SetModel(string model)
        {
            car.Model = model;
        }

        public void SetColor(string color)
        {
            car.Color = color;
        }

        public void SetEngine(string engine)
        {
            car.Engine = engine;
        }

        public ICar Build()
        {
            return car;
        }
    }

}
