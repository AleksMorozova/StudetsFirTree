using Spruce.Props;
using System;

namespace Spruce
{
    public class Spruce : Plant, IPersistent
    {
        private const Colors _color = Colors.Green;
        private const Appearances _appearance = Appearances.Slim;
        public override Colors Color
        {
            get
            {
                return _color;
            }
        }
        public override Appearances Appearance
        {
            get
            {
                return _appearance;
            }
        }

        public Spruce()
        {
            Year.SeasonChanged += new EventHandler<SeasonsEventArgs>(SeasonChanged);
        }

        public void IgnoreSeason(Seasons _season)
        {
            Console.WriteLine("{0} came, but i still {1} and {2}", 
                _season, Appearance, Color);
        }

        public override void SeasonChanged(object sender, SeasonsEventArgs e)
        {
            IgnoreSeason(e.CurrentSeason);
        }
    }
}
