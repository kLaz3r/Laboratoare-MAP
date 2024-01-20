using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Bridge
{
    public class Tree : Branch
    {
        public Tree(string name) : base(name, null)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine("Displaying Tree:");
            base.Display(depth);
        }
    }
}
