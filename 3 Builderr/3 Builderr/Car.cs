using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builderr
{
    public class Car : ICar, ICarPrototype
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public bool IsClone { get; set; }

        public ICar Clone()
        {
            Car clone = (Car)this.MemberwiseClone();

            if (IsClone)
            {
                clone.Color = "Red"; 
            }

            return clone;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Color: {Color}, Engine: {Engine}, IsClone: {IsClone}";
        }
    }
}
