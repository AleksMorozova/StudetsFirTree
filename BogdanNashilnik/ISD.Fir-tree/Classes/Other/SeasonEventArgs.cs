using System;

namespace ISD.Fir_tree.Classes
{
    class SeasonEventArgs : EventArgs
    {
        public Season Season { get; private set; }

        public SeasonEventArgs(Season season)
        {
            this.Season = season;
        }
    }
}
