namespace Spruce.Props
{
    public class SeasonsEventArgs
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
        public SeasonsEventArgs(Seasons _season)
        {
            CurrentSeason = _season;
        }
    }
}
