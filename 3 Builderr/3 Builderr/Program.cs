using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builderr
{
    class Program
    {
        static void Main()
        {
            ICarBuilder builder = new CarBuilder();
            ICarBuildDirector director = new CarBuildDirector();
            director.Construct(builder);
            ICar originalCar = builder.Build();

            ICarPrototype carPrototype = originalCar as ICarPrototype;
            ICar clonedCar = carPrototype.Clone();

            Console.WriteLine("Original Car:");
            Console.WriteLine(originalCar);

            Console.WriteLine("\nCloned Car:");
            Console.WriteLine(clonedCar);
        }
    }
}
