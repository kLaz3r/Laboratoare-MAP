using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Bridge
{
    internal class Program
    {
        static void Main()
        {
            Vegetation tree = new Tree("Root");
            Vegetation branch1 = new Branch("Branch 1", "Root");
            Vegetation branch2 = new Branch("Branch 2", "Root");
            Vegetation leaf1 = new Leaf("Leaf 1", "Branch 1");
            Vegetation leaf2 = new Leaf("Leaf 2", "Branch 2");

            tree.Add(branch1);
            tree.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);

            tree.Display(0);

            branch2.Remove(leaf2);

            Console.WriteLine("\nAfter removing Leaf 2:");
            tree.Display(0);
        }
    }
}
