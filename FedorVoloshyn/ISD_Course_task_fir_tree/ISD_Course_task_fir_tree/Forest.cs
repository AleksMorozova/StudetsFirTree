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
        private Year yearInForest;
        public Forest()
        {
            forestTrees = new List<ITree>();
        }
        public void AddTree(ITree treeInForest)
        {
            forestTrees.Add(treeInForest);
            yearInForest.SeasonChanged += forestTrees.Last().SeasonChangedReaction;
        }
        public void GrowAllPlants()
        {
            foreach (ITree currentTree in forestTrees)
                currentTree.Grow("лесу");
        }

        public void NextSeason()
        {
            yearInForest.NextSeason();
        }
    }
}
