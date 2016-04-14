using ISD.Fir_tree.Interfaces;
using System;
using ISD.Fir_tree.Classes;

namespace ISD.Fir_tree.Classes
{
    abstract public class Tree : IHaveName, ISnowed
    {
        protected string name;
        protected int age;
        protected double height;
        protected TreeConstitution constitution;
        protected bool wrappedWithSnow;
        protected Animal animal;
        protected Color color;

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
        public Color Color
        {
            get
            {
                Console.Write("Цвет дерева \"{0}\": ", this.name);
                return this.color;
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
        public abstract TreeConstitution Constitution { get; }
        
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
        
        public void PutAnimal(Animal animal)
        {
            this.animal = animal;
            Console.WriteLine("Теперь под деревом \"{0}\" находится животное \"{1}\".", this.name, animal.Name);
        }
        public abstract void ChangeSeason(Season season);
    }
}
