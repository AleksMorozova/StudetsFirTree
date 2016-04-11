using System;
using Spruce.Props;

namespace Spruce
{
    public abstract class Plant
    {
        private Colors _color;
        private Appearances _appearance;

        public virtual Colors Color
        {
            get
            {
                return _color;
            }
        }
        public virtual Appearances Appearance
        {
            get
            {
                return _appearance;
            }
        }
        public abstract void SeasonChanged(object sender, SeasonsEventArgs e);
        public void Grow()
        {
            Console.WriteLine("Growing..");
        }
        public void ToSprout()
        {
            Console.WriteLine("I was born!");
        }


    }
}
