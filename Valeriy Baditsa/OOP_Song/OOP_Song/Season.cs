using System;

namespace OOP_Song
{   
    public class Season
    {
        Seasons CurrentSeazon { get; set; }
        double Temperature {get; set; }

        public Season(Seasons currentSeason)
        {
            this.CurrentSeazon = currentSeason;
            Console.WriteLine("Setted sezon = {0}", this.CurrentSeazon);
        }

        public event EventHandler<SeasonEventArgs> SeasonChanged;

        public void OnSezonChanged(Seasons changedSeasonName)
        {
            CurrentSeazon = changedSeasonName;
            Console.WriteLine("Season is changed");
            if (SeasonChanged != null)
            {
                SeasonChanged(this, new SeasonEventArgs(changedSeasonName));                
            }
        }
    }
}
