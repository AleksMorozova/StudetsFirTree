using System;

namespace Spruce.Props
{
    public static class Year
    {
        private static int _currentYear;
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
        public static int CurrentYear
        {
            get
            {
                return _currentYear;
            }
            private set
            {
                _currentYear += value;
                if (YearChanged != null)
                    YearChanged(null, new YearsEventArgs(CurrentSeason, CurrentYear));
            }
        }
        public static event EventHandler<YearsEventArgs> SeasonChanged;
        public static event EventHandler<YearsEventArgs> YearChanged;

        static Year()
        {
            _currentYear = 2016;
            CurrentSeason = Seasons.Winter;
        }

        public static void ChangeSeason()
        {
            if (CurrentSeason == Seasons.Autumn)
            {
                CurrentSeason = Seasons.Winter;
                CurrentYear = 1;
            }
            else if (CurrentSeason == Seasons.Summer)
                CurrentSeason = Seasons.Autumn;
            else if (CurrentSeason == Seasons.Spring)
                CurrentSeason = Seasons.Summer;
            else
                CurrentSeason = Seasons.Spring;
            if (SeasonChanged != null)
                SeasonChanged(null, new YearsEventArgs(CurrentSeason, CurrentYear));
        }
    }
}
