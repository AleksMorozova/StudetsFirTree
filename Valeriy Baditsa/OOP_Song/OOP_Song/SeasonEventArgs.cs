using System;

namespace OOP_Song
{
    public class SeasonEventArgs : EventArgs
    {
        public Seasons CurrentSezon { get; set; }
        public double Temperature { get; set; }

        public SeasonEventArgs(Seasons season)
        {
            this.CurrentSezon = season;
        }
    }
}
