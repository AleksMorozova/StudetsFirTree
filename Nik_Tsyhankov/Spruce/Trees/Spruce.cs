using Spruce.Props;
using Spruce.Trees;
using System;

namespace Spruce
{
    public class Spruce : IPlant, IPersistent
    {
        private const Colors _color = Colors.Green;
        private const Appearances _appearance = Appearances.Slim;
        private int _hight;
        public Colors Color
        {
            get
            {
                return _color;
            }
        }
        public Appearances Appearance
        {
            get
            {
                return _appearance;
            }
        }
        public int Hight
        {
            get
            {
                return _hight;
            }
            private set
            {
                _hight = value;
            }
        }

        public Spruce()
        {
            Hight = 0;
            Year.SeasonChanged += SeasonChanged;
            Year.MonthChanged += Grow;
            Console.WriteLine("I was born!");
        }

        public void IgnoreSeason(Seasons _season)
        {
            Console.WriteLine("{0} came, but i still {1} and {2}", 
                _season, Appearance, Color);
        }
        public void Grow(object sender, YearsEventArgs e)
        {
            Console.WriteLine("Growing...");
            Hight += 10;
            Console.WriteLine("Current hight: {0} sm.", Hight);
        }
        public void SeasonChanged(object sender, YearsEventArgs e)
        {
            IgnoreSeason(e.CurrentSeason);
        }
    }
}
