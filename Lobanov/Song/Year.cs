using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
   public class Year:ISeasonProvider
    {
        public Seasons CurrentSeason { get; private set; }
        public event EventHandler<SeasonEventArgs> OnSeasonChanged;

        public Year(Seasons initseason)
        {
            CurrentSeason = initseason;
        }
        public void ChangeSeason()
        {
            if (CurrentSeason == Seasons.Summer)
            {
                CurrentSeason = Seasons.Winter;
            }
            else
            {
                CurrentSeason = Seasons.Summer;
            }
            if (OnSeasonChanged != null)
            {
                    OnSeasonChanged(this, new SeasonEventArgs(CurrentSeason));
            }
        }
    }
}
