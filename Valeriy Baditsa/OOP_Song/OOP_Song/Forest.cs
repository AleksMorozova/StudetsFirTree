using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Song
{
    class Forest
    {
        List<ITree> treesList = new List<ITree>();
        Sezon sezon;

        public void AddTree(ITree tree)
        {
            treesList.Add(tree);
            sezon.SezonChanged += tree.reactionsTreesOn_SezonChanged;
            Console.WriteLine("{0} is in the forest", tree.Name);            
        }

        public void TreesGrow()
        {
            foreach (ITree tree in treesList)
            {
                tree.Grow();
            }
        }

        public void AddSezon(Sezon _sezon)
        {
            sezon = _sezon;
        }
        
    }
}
