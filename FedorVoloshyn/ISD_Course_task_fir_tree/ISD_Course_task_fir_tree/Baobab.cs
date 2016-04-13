using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    class Baobab : ITree
    {
        private string name;
        private PlantColors color;
        public string Name { get { return name; } }
        public PlantColors Color { get { return color; }  }
        public Waists Waist { get { return Waists.Fat; } }
        public Baobab(string name, string growBorn)
        {
            this.name = name;
            Year.SeasonChanged += SeasonChangedReaction;
            SeasonChangedReaction(Year.Season);
        }
        public void Grow(string growPlace) { }

        public void SeasonChangedReaction(Seasons currentSeason)
        {
            switch(currentSeason)
            {
                case Seasons.Summer: color = PlantColors.Green;
                    break;
                case Seasons.Winter: color = PlantColors.Bold;
                    break;
                default: color = PlantColors.Yellow;
                    break;
            }
        }
    }
}
