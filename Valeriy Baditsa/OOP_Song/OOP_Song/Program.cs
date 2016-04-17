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
            Season sezon = new Season(Seasons.spring);
            Forest forest = new Forest(sezon);                        
            forest.AddTree(new Fir("Fir"));          
            forest.TreesGrow();
            sezon.OnSezonChanged(Seasons.summer);

            Console.WriteLine("______________");
            Console.WriteLine("Added new tree");
            Console.WriteLine("_____________");

            forest.AddTree(new Maple("Maple_Tree"));
            forest.TreesGrow();
            sezon.OnSezonChanged(Seasons.autumn);

            Console.ReadKey();
        }
        
    }
}
