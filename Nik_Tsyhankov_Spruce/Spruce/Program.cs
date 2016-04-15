using Spruce.Props;
using Spruce.Trees;
using System;

namespace Spruce
{
    class Program
    {
        static void Main(string[] args)
        {
            ISeasonChanger _year = new Year();
            Forest _forest = new Forest(_year);

            _forest.AddTree(new Spruce());
            _forest.AddTree(new Oak());

            for (int i = 0; i < 12; i++)
            {
                _year.ChangeMonth();
            }

            Console.ReadKey();
        }
    }
}
