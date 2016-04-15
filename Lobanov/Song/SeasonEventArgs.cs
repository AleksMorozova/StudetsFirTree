using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public class SeasonEventArgs:EventArgs
    {
        public Seasons Current { get;private set; }

        public SeasonEventArgs(Seasons now)
        {
            this.Current = now;
        }
    }
}
