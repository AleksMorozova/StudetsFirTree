using Spruce.Props;
using System;

namespace Spruce
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest _forest = new Forest();
            Spruce _fir = new Spruce();

            _forest.Trees.Add(_fir);
            _forest.Trees[_forest.Trees.IndexOf(_fir)].ToSprout();
            _forest.Trees[_forest.Trees.IndexOf(_fir)].Grow();

            Year.ChangeSeason();
            Year.ChangeSeason();
            Year.ChangeSeason();
            Year.ChangeSeason();

            Console.ReadKey();
        }
    }
}
