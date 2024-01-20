using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adapter
{
    public class RectangularSocket : IRectangularSocket
    {
        public string GetSupply(string firstWire, string secondWire)
        {
            return $"Rectangular power supply connected: {firstWire}, {secondWire}";
        }
    }
}
