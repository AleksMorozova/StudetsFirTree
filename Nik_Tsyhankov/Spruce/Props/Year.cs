using System;

namespace Spruce.Props
{
    public static class Year
    {
        private static Seasons _currentSeason;
        public static Seasons CurrentSeason
        {
            get
            {
                return _currentSeason;
            }
            private set
            {
                _currentSeason = value;
            }
        }
        public static event EventHandler<SeasonsEventArgs> SeasonChanged;

        static Year()
        {
            CurrentSeason = Seasons.Winter;
        }

        public static void ChangeSeason()
        {
            if (CurrentSeason == Seasons.Autumn)
                CurrentSeason = Seasons.Winter;
            else if (CurrentSeason == Seasons.Summer)
                CurrentSeason = Seasons.Autumn;
            else if (CurrentSeason == Seasons.Spring)
                CurrentSeason = Seasons.Summer;
            else
                CurrentSeason = Seasons.Spring;
            if (SeasonChanged != null)
                SeasonChanged(null, new SeasonsEventArgs(CurrentSeason));
        }
    }
}
