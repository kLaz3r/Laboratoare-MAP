using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builderr
{
    public class CarBuildDirector : ICarBuildDirector
    {
        public void Construct(ICarBuilder builder)
        {
            builder.SetModel("Sedan");
            builder.SetColor("Blue");
            builder.SetEngine("Petrol");
        }
    }
}
