using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Factory
{
    public class Truck : Car
    {
        public decimal Weight { get; set; }

        public override void DriveTest(int km)
        {
            Console.WriteLine($"Truck ID {ID} driven for {km} km.");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Weight: {Weight} tons";
        }
    }
}
