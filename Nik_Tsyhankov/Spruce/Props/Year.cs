using System;

namespace Spruce.Props
{
    public static class Year
    {
        private static int _currentMonth;
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
        public static int CurrentMonth
        {
            get
            {
                return _currentMonth;
            }
            private set
            {
                if (value > 12)
                    _currentMonth = 1;
                else
                    _currentMonth = value;
                if (MonthChanged != null)
                    MonthChanged(null, new YearsEventArgs(CurrentSeason));
            }
        }
        public static event EventHandler<YearsEventArgs> SeasonChanged;
        public static event EventHandler<YearsEventArgs> MonthChanged;

        static Year()
        {
            CurrentMonth = 1;
            CurrentSeason = Seasons.Winter;
        }

        public static void ChangeMonth()
        {
            CurrentMonth += 1;

            if (CurrentMonth > 11 || CurrentMonth < 3)
                CurrentSeason = Seasons.Winter;
            else if (CurrentMonth > 2 && CurrentMonth < 6)
                CurrentSeason = Seasons.Spring;
            else if (CurrentMonth > 5 && CurrentMonth < 9)
                CurrentSeason = Seasons.Summer;
            else
                CurrentSeason = Seasons.Autumn; 

            if (CurrentMonth == 3 || CurrentMonth == 6 || CurrentMonth == 9 || CurrentMonth == 12)
            {
                if (SeasonChanged != null)
                    SeasonChanged(null, new YearsEventArgs(CurrentSeason));
            }
        }
    }
}
