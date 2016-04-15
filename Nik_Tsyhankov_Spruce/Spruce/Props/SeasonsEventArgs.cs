namespace Spruce.Props
{
    public delegate void SeasonHandler(YearsEventArgs e);
    public class YearsEventArgs
    {
        private Seasons _season;
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
        public YearsEventArgs(Seasons _season)
        {
            CurrentSeason = _season;
        }
    }
}
