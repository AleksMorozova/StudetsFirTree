namespace Spruce.Props
{
    public class YearsEventArgs
    {
        private Seasons _season;
        private int _year;
        public Seasons CurrentSeason
        {
            get
            {
                return _season;
            }
            private set
            {
                _season = value;
            }
        }
        public int CurrentYear
        {
            get
            {
                return _year;
            }
            private set
            {
                _year = value;
            }
        }
        public YearsEventArgs(Seasons _season, int _year)
        {
            this._year = _year;
            CurrentSeason = _season;

        }
    }
}
