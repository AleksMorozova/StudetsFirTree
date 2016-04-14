using Spruce.Props;
using Spruce.Trees;
using System.Collections.Generic;

namespace Spruce
{
    public class Forest
    {
        private List<IPlant> _trees;

        public Forest(ISeasonChanger _year)
        {
            _year.MonthChanged += GrowTrees;
            _year.SeasonChanged += ChangeTreesProperties;

            _trees = new List<IPlant>();
        }

        public void AddTree(IPlant _plant)
        {
            _trees.Add(_plant);
        }
        private void GrowTrees(YearsEventArgs e)
        {
            foreach(var tree in _trees)
            {
                tree.Grow();
            }
        }
        private void ChangeTreesProperties(YearsEventArgs e)
        {
            foreach (var tree in _trees)
            {
                tree.SeasonChanged(e);
            }
        }
    }
}
