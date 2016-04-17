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
            season.SeasonChanged += season_SezonChanged;
        }

        private void season_SezonChanged(object sender, SeasonEventArgs e)
        {
            foreach (ITree tree in treesList)
            {
                tree.reactionTreeOn_SezonChanged(e);
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
