using ISD.Fir_tree.Interfaces;
using System;
using ISD.Fir_tree.Classes;

namespace ISD.Fir_tree.Classes
{
    abstract class Tree : INamed, IGrowing, ISeasonable, IColourful, ISnowed, IAnimalContainer
    {
        protected string name;
        protected int age;
        protected double height;
        protected TreeConstitution constitution;
        protected Season season;
        protected bool wrappedWithSnow;
        protected Animal animal;

        public int Age
        {
            get
            {
                return age;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public virtual void Grow(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Возраст должен быть неотрицательным числом.");
            }
            this.age += age;
            this.GrowInHeight(age);
        }
        protected abstract void GrowInHeight(int age);
        public Season Season
        {
            get
            {
                return season;
            }
        }
        public abstract TreeConstitution Constitution { get; }
        public abstract Color Color { get; }
        public bool WrappedWithSnow
        {
            get
            {
                return wrappedWithSnow;
            }

            set
            {
                wrappedWithSnow = value;
            }
        }
        public Animal Animal
        {
            get
            {
                return animal;
            }

            set
            {
                Console.WriteLine("Теперь под деревом \"{0}\" находится животное \"{1}\".", this.name, value.Name);
                animal = value;
            }
        }

        public abstract void ChangeSeason(Season season);
    }
}
