using Spruce.Props;
using System;

namespace Spruce.Trees
{
    public class Oak : IPlant
    {
        private Colors _color;
        private Appearances _appearance;
        private int _hight;
        public Colors Color
        {
            get
            {
                return _color;
            }
            private set
            {
                _color = value;
            }
        }
        public Appearances Appearance
        {
            get
            {
                return _appearance;
            }
            private set
            {
                _appearance = value;
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

        public Oak()
        {
            Hight = 0;
            Appearance = Appearances.Skinny;
            Color = Colors.None;
            Console.WriteLine("Oak:");
            Console.WriteLine("I was born!");
        }
        public void Grow()
        {
            Console.WriteLine("Oak:");
            Console.WriteLine("Growing...");
            Hight += 10;
            Console.WriteLine("Current hight: {0} sm.", Hight);
        }
        public void SeasonChanged(YearsEventArgs e)
        {
            if (e.CurrentSeason == Seasons.Autumn)
            {
                Color = Colors.Orange;
                Appearance = Appearances.Dry;
            }
            else if (e.CurrentSeason == Seasons.Winter)
            {
                Color = Colors.None;
                Appearance = Appearances.Lush;
            }
            else if (e.CurrentSeason == Seasons.Spring)
            {
                Color = Colors.Yellow;
                Appearance = Appearances.Slim;
            }
            else
            {
                Color = Colors.Green;
                Appearance = Appearances.Еhriving;
            }

            Console.WriteLine("Oak:");
            Console.WriteLine("{0} came, i am {1} and {2}",
                e.CurrentSeason, Appearance, Color);
        }
    }
}
