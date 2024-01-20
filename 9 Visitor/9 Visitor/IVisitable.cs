using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Visitor
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
