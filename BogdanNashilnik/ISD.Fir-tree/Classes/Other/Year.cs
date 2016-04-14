using System;

namespace ISD.Fir_tree.Classes
{
    public class Year
    {
        private Season currentSeason = Season.Winter;
        public delegate void SeasonChanged(object sender, EventArgs e);
        public event SeasonChanged OnSeasonChanged;

        public Season CurrentSeason
        {
            get
            {
                return currentSeason;
            }
        }

        public void NextSeason()
        {
            if ((int)currentSeason >= 3)
            {
                currentSeason = Season.Winter;
            }
            else
            {
                currentSeason++;
            }
            OnSeasonChanged(null, new SeasonEventArgs(currentSeason));
        }
    }
}
