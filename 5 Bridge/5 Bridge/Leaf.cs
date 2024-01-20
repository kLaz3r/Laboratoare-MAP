using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Bridge
{
    public class Leaf : Vegetation
    {
        public Leaf(string name, string parentName) : base(name, parentName)
        {
        }

        public override void Add(Vegetation child)
        {
            Console.WriteLine("Cannot add to a leaf.");
        }

        public override void Remove(Vegetation child)
        {
            Console.WriteLine("Cannot remove from a leaf.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('*', depth) + name);
        }
    }
}
