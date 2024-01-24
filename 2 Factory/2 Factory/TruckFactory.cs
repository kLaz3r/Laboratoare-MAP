using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Factory
{
    public class TruckFactory : CarFactory
    {
        public override Car GetCar(string brand)
        {
            switch (brand)
            {
                case "Mercedes-Benz":
                    return new Truck { Brand = "Mercedes-Benz" };
                case "Volvo":
                    return new Truck { Brand = "Volvo" };
                case "Renault":
                    return new Truck { Brand = "Renault" };
                case "Volkswagen":
                    return new Truck { Brand = "Volkswagen" };
                default:
                    return null;
            }
        }
    }
}
