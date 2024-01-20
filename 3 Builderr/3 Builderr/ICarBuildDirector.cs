using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builderr
{
    public interface ICarBuildDirector
    {
        void Construct(ICarBuilder builder);
    }
}
