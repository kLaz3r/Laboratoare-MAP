using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Factory
{
    public class Automobile : Car
    {
        public string Model { get; set; }

        public override void DriveTest(int km)
        {
            Console.WriteLine($"Automobile ID {ID} driven for {km} km.");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Model: {Model}";
        }
    }
}
