using System;

namespace ISD.Fir_tree.Classes
{
    class Bunny : Animal
    {
        public Bunny(string name, Color color, Bravery bravery)
        {
            this.name = name;
            this.color = color;
            this.bravery = bravery;
            this.mood = Mood.Sad;
            this.footWooliness = Wooliness.Shaggy;
        }
        public Bunny() : this("Безымянный заяц", Color.Grey, Bravery.Coward) { }

        public override void Move()
        {
            Console.WriteLine("Заяц \"{0}\" скачет.", this.name);
        }
    }
}
