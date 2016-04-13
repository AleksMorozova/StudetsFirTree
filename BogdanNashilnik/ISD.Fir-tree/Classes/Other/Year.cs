using System;

namespace ISD.Fir_tree.Classes
{
    static public class Year
    {
        private static Season currentSeason = Season.Winter;
        public delegate void SeasonChanged(object sender, EventArgs e);
        static public event SeasonChanged OnSeasonChanged;

        public static Season CurrentSeason
        {
            get
            {
                return currentSeason;
            }
        }

        public static void ChangeSeason()
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
