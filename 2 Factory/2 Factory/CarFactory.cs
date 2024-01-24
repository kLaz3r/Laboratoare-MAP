using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Factory
{
    public abstract class CarFactory
    {
        private static int lastID = 0;

        protected int LastID => lastID;

        public abstract Car GetCar(string brand);
    }
}
