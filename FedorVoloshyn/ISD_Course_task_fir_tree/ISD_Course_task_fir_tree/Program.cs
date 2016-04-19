using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Year yearInForest = new Year();
            Forest MyForest = new Forest(yearInForest);
            MyForest.AddTree(new FirTree("Yolochka", "лесу"));
            MyForest.GrowAllPlants();
            yearInForest.NextSeason();
        }
    }
}
