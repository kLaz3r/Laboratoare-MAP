using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Factory
{
    public abstract class Car
    {
        private static int lastID = 0;

        public int ID { get; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        protected Car()
        {
            ID = ++lastID;
        }

        public abstract void DriveTest(int km);

        public override string ToString()
        {
            return $"ID: {ID}, Brand: {Brand}, Color: {Color}, Price: {Price:C}";
        }
    }
}
