using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adapter
{
    public interface IRectangularSocket
    {
        string GetSupply(string firstWire, string secondWire);
    }
}
