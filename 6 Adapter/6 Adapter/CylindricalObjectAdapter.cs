using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adapter
{
    public class CylindricalObjectAdapter : ICylindricalPlug
    {
        private readonly IRectangularSocket rectangularSocket;

        public CylindricalObjectAdapter(IRectangularSocket rectangularSocket)
        {
            this.rectangularSocket = rectangularSocket;
        }

        public string GetPowerSupply(EAdapterType type)
        {
            if (type == EAdapterType.ObjectAdapter)
            {
                return rectangularSocket.GetSupply("Cylindrical plug wire 1", "Cylindrical plug wire 2");
            }
            else
            {
                return "Invalid adapter type for Object Adapter.";
            }
        }
    }
}
