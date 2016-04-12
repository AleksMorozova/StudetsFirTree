using Spruce.Trees;
using System.Collections.Generic;

namespace Spruce
{
    public class Forest
    {
        private List<IPlant> _trees;

        public Forest()
        {
            _trees = new List<IPlant>();
        }

        public void AddTree(IPlant _plant)
        {
            _trees.Add(_plant);
        }
    }
}
