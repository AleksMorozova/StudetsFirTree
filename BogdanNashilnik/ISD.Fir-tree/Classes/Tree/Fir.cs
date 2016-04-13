using System;

namespace ISD.Fir_tree.Classes
{
    class Fir : Tree
    {
        const int MAX_HEIGHT = 3;

        public override TreeConstitution Constitution
        {
            get
            {
                Console.Write("Тип ёлки \"{0}\": ", this.name);
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
            this.color = Color.Green;
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
        public override void ChangeSeason(Season season) { }
    }
}
