using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Factory
{
    public class AutomobileFactory : CarFactory
    {
        public override Car GetCar(string brand)
        {
            switch (brand)
            {
                case "Mercedes-Benz":
                    return new Automobile { Brand = "Mercedes-Benz" };
                case "Volvo":
                    return new Automobile { Brand = "Volvo" };
                case "Renault":
                    return new Automobile { Brand = "Renault" };
                case "Volkswagen":
                    return new Automobile { Brand = "Volkswagen" };
                default:
                    return null;
            }
        }
    }
}
