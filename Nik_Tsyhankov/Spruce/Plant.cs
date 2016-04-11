using System;
using Spruce.Props;

namespace Spruce
{
    public abstract class Plant
    {
        private Colors _color;
        private Appearances _appearance;
        private int _age;

        public virtual Colors Color
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
        public virtual Appearances Appearance
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
        public virtual int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                _age = value;
            }
        }
        public abstract void SeasonChanged(object sender, YearsEventArgs e);
        public abstract void Grow(object sender, YearsEventArgs e);
        public void ToSprout()
        {
            Console.WriteLine("I was born!");
        }
    }
}
