using System;
using ISD.Fir_tree.Interfaces;

namespace ISD.Fir_tree.Classes
{
    abstract class Animal : IHaveName
    {
        protected string name;
        protected Color color;
        protected Mood mood;
        protected Bravery bravery;
        protected Wooliness footWooliness;

        public Color Color
        {
            get
            {
                Console.Write("Цвет животного \"{0}\": ", this.name);
                return color;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Mood Mood
        {
            get
            {
                Console.Write("Настроение животного \"{0}\": ", this.name);
                return mood;
            }
            set
            {
                mood = value;
            }
        }
        public Bravery Bravery
        {
            get
            {
                Console.Write("Храбрость животного \"{0}\": ", this.name);
                return bravery;
            }
        }
        public Wooliness FootWooliness
        {
            get
            {
                Console.Write("Мохнатость ног животного \"{0}\": ", this.name);
                return footWooliness;
            }
        }

        public abstract void Move();
    }
}
