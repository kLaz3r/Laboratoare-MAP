using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Bridge
{
    public class Branch : Vegetation
    {
        private List<Vegetation> children = new List<Vegetation>();

        public Branch(string name, string parentName) : base(name, parentName)
        {
        }

        public override void Add(Vegetation child)
        {
            children.Add(child);
        }

        public override void Remove(Vegetation child)
        {
            children.Remove(child);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('*', depth) + name);

            foreach (var child in children)
            {
                child.Display(depth + 1);
            }
        }
    }
}
