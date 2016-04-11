using Spruce.Props;
using System;

namespace Spruce
{
    public class Spruce : Plant, IPersistent
    {
        private const Colors _color = Colors.Green;
        private const Appearances _appearance = Appearances.Slim;
        private int _age;
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
        new public int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                _age += value;
            }
        }

        public Spruce()
        {
            _age = 0;
            ToSprout();
            Year.SeasonChanged += new EventHandler<YearsEventArgs>(SeasonChanged);
            Year.YearChanged += new EventHandler<YearsEventArgs>(Grow);
        }

        public void IgnoreSeason(Seasons _season)
        {
            Console.WriteLine("{0} came, but i still {1} and {2}", 
                _season, Appearance, Color);
        }
        public override void Grow(object sender, YearsEventArgs e)
        {
            Console.WriteLine("Growing...");
            Age = 1;
            Console.WriteLine("Going {0} year.", e.CurrentYear);
            Console.WriteLine("Current age: {0}", Age);
        }
        public override void SeasonChanged(object sender, YearsEventArgs e)
        {
            IgnoreSeason(e.CurrentSeason);
        }
    }
}
