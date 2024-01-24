using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Factory
{
    class Program
    {
        static void Main()
        {
            var automobileFactory = new AutomobileFactory();
            var truckFactory = new TruckFactory();

            List<Car> cars = new List<Car>
        {
            automobileFactory.GetCar("Mercedes-Benz"),
            automobileFactory.GetCar("Volvo"),
            truckFactory.GetCar("Renault"),
            truckFactory.GetCar("Volkswagen")
        };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
                car.DriveTest(50);
                Console.WriteLine();
            }
        }
    }
}
