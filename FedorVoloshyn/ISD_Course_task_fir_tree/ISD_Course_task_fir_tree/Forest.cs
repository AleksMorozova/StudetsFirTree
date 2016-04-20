using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    class Forest
    {
        private List<ITree> forestTrees;
        public Forest(Year year)
        {
            forestTrees = new List<ITree>();
            year.SeasonChanged += SeasonChanged;
        }
        public void AddTree(ITree treeInForest)
        {
            forestTrees.Add(treeInForest);
        }
        public void GrowAllPlants()
        {
            foreach (ITree currentTree in forestTrees)
                currentTree.Grow("лесу");
        }
        public void SeasonChanged(Seasons season)
        {
            foreach (ITree tree in forestTrees)
                tree.SeasonChangedReaction(season);
        }
    }
}
