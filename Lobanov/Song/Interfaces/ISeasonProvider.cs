using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public interface ISeasonProvider
    {
        void ChangeSeason();
        event EventHandler<SeasonEventArgs> OnSeasonChanged;
    }
}
