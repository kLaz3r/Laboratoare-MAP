using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adapter
{

    public enum EAdapterType
    {
        ClassAdapter,
        ObjectAdapter
    }
    internal class Program
    {
        static void Main()
        {
            CylindricalClassAdapter classAdapter = new CylindricalClassAdapter();
            string classAdapterResult = classAdapter.GetPowerSupply(EAdapterType.ClassAdapter);
            Console.WriteLine(classAdapterResult);

            IRectangularSocket rectangularSocket = new RectangularSocket();
            CylindricalObjectAdapter objectAdapter = new CylindricalObjectAdapter(rectangularSocket);
            string objectAdapterResult = objectAdapter.GetPowerSupply(EAdapterType.ObjectAdapter);
            Console.WriteLine(objectAdapterResult);
        }
    }
}
