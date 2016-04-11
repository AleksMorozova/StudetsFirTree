using Spruce.Props;
using System;

namespace Spruce
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest _forest = new Forest();

            _forest.Trees.Add(new Spruce());

            Year.ChangeSeason();
            Year.ChangeSeason();
            Year.ChangeSeason();
            Year.ChangeSeason();

            Console.ReadKey();
        }
    }
}
