using Spruce.Props;
using System;

namespace Spruce
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest _forest = new Forest();

            _forest.AddTree(new Spruce());

            for(int i = 0; i < 12; i++)
            {
                Year.ChangeMonth();
            }

            Console.ReadKey();
        }
    }
}
