using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adapter
{
    public class CylindricalClassAdapter : RectangularSocket, ICylindricalPlug
    {
        public string GetPowerSupply(EAdapterType type)
        {
            if (type == EAdapterType.ClassAdapter)
            {
                return GetSupply("Cylindrical plug wire 1", "Cylindrical plug wire 2");
            }
            else
            {
                return "Invalid adapter type for Class Adapter.";
            }
        }
    }
}
