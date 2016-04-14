using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    public delegate void SeasonChangedHandler(Seasons season);
    class Year
    {
        private Seasons season = Seasons.Winter;
        public Seasons Season { get { return season; } }

        public event SeasonChangedHandler SeasonChanged;
        public void NextSeason()
        {
            if (season == Seasons.Winter)
                season = Seasons.Summer;
            else
                season = Seasons.Winter;

            SeasonChanged(season);
        }
    }
}
