using System;

namespace ISD.Fir_tree.Classes
{
    class Wolf : Animal
    {
        public Wolf(string name, Color color)
        {
            this.name = name;
            this.color = color;
            this.mood = Mood.Angry;
            this.bravery = Bravery.Brave;
            this.footWooliness = Wooliness.Medium;
        }
        public Wolf() : this("Безымянный волк", Color.Grey) { }

        public override void Move()
        {
            Console.WriteLine("Волк \"{0}\" бежит рысцою.", this.name);
        }
    }
}
