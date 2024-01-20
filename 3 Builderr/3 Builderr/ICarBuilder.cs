using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builderr
{
    public interface ICarBuilder
    {
        void SetModel(string model);
        void SetColor(string color);
        void SetEngine(string engine);
        ICar Build();
    }
}
