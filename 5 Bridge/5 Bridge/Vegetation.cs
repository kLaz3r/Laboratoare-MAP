using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Bridge
{
    public abstract class Vegetation
    {
        protected string name;
        protected string parentName;

        public Vegetation(string name, string parentName)
        {
            this.name = name;
            this.parentName = parentName;
        }

        public abstract void Add(Vegetation child);
        public abstract void Remove(Vegetation child);
        public abstract void Display(int depth);
    }
}
