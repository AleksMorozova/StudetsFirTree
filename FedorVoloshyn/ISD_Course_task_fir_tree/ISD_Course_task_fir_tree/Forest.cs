using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    class Forest
    {
        private const int defaultTreeCount = 100;
        private Tree[] forestTrees;
        private YearTimes yearTime;
        public Tree[] ForestTrees { get { return forestTrees; } }
        public YearTimes YearTime
        {
            get { return yearTime; }
            set { yearTime = value; }
        }
        public Forest()
        {
            forestTrees = new Tree[defaultTreeCount];
        }
        public Forest(Tree firstTreeInForest)
        {
            forestTrees = new Tree[defaultTreeCount];
            forestTrees[0] = firstTreeInForest;
            if(firstTreeInForest is FirTree)
            {
                Console.WriteLine("В лесу родилась елочка");
            }
        }
        public Forest(Tree[] newForest)
        {
            forestTrees = newForest;
        }
    }
}
