using System;

namespace ISD.Fir_tree.Classes
{
    class Fir : Tree
    {
        const int MAX_HEIGHT = 3;

        public override Color Color
        {
            get
            {
                var color = Color.Green;
                Console.Write("Цвет ёлки \"{0}\" в сезон {1}: ", this.name, this.season);
                return color;
            }
        }
        public override TreeConstitution Constitution
        {
            get
            {
                var constitution = TreeConstitution.Slim;
                Console.Write("Тип ёлки \"{0}\" в сезон {1}: ", this.name, this.season);
                return constitution;
            }
        }

        public Fir() : this("Безымянная ёлка") { }
        public Fir(string name)
        {
            this.constitution = TreeConstitution.Slim;
            this.age = 0;
            this.height = 0;
            this.name = name;
        }

        protected override void GrowInHeight(int age)
        {
            if (this.age >= 6)
            {
                this.height = Fir.MAX_HEIGHT;
            }
            else
            {
                this.height = age / 2d;
            }
            Console.WriteLine("Ёлка \"{0}\" за {1} лет выросла до {2} метров.", this.name, age, this.height);
        }
        public override void ChangeSeason(Season season)
        {
            this.season = season;
        }
    }
}
