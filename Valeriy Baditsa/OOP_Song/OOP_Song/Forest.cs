using System;
using System.Collections.Generic;

namespace OOP_Song
{
    public class Forest
    {
        List<ITree> treesList;

        public void AddTree(ITree tree)
        {
            treesList.Add(tree);
            Console.WriteLine("{0} is in the forest", tree.Name);
        }

        public Forest(Season season)
        {
            treesList = new List<ITree>();
            season.SeasonChanged += season_OnSeasonChanged;
        }

        private void season_OnSeasonChanged(object sender, SeasonEventArgs e)
        {
            foreach (ITree tree in treesList)
            {
                tree.ChangeState(e);
            }
        }        

        public void TreesGrow()
        {
            foreach (ITree tree in treesList)
            {
                tree.Grow();
            }
        }       
        
    }
}
