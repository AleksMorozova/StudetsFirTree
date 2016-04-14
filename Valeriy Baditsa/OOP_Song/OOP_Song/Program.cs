using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Song
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            Sezon sezon = new Sezon(Sezons.spring);
            forest.AddSezon(sezon);
            forest.AddTree(new Fir("Fir"));          
            forest.TreesGrow();
            sezon.OnSezonChanged(Sezons.spring);

            Console.WriteLine("______________");
            Console.WriteLine("Added new tree");
            Console.WriteLine("______________");

            forest.AddTree(new Maple("Maple_Tree"));
            forest.TreesGrow();
            sezon.OnSezonChanged(Sezons.winter);

            Console.ReadKey();
        }
        
    }
}
