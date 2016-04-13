using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD.Fir_tree.Classes
{
    public class Oak : Tree
    {
        const int MAX_HEIGHT = 5;

        public override TreeConstitution Constitution
        {
            get
            {
                var constitution = TreeConstitution.Fat;
                Console.Write("Тип дуба \"{0}\": ", this.name);
                return constitution;
            }
        }

        public Oak() : this("Безымянный дуб") { }
        public Oak(string name)
        {
            this.constitution = TreeConstitution.Fat;
            this.age = 0;
            this.height = 0;
            this.name = name;
        }

        protected override void GrowInHeight(int age)
        {
            if (this.age >= 10)
            {
                this.height = Oak.MAX_HEIGHT;
            }
            else
            {
                this.height = age;
            }
            Console.WriteLine("Дуб \"{0}\" за {1} лет вырос до {2} метров.", this.name, age, this.height);
        }
        public override void ChangeSeason(Season season)
        {
            switch (season)
            {
                case Season.Autumn:
                    this.color = Color.Orange;
                    break;
                case Season.Winter:
                    this.color = Color.None;
                    break;
                default:
                    this.color = Color.Green;
                    break;
            }
        }
    }
}
