using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    class FirTree : ITree
    {
        private string name;
        public string Name { get { return name; } }
        public PlantColors Color { get { return PlantColors.Green; } }
        public Waists Waist { get { return Waists.Shapely; } }
        public FirTree(string name, string growBorn)
        {
            this.name = name;
            Console.WriteLine("В {0} родилась елочка", growBorn);
            Year.SeasonChanged += SeasonChangedReaction;
        }
        public void Grow(string growPlace) { Console.WriteLine("В {0} она росла", growPlace); }
        public void SeasonChangedReaction(Seasons currentSeason) { }
    }
}
