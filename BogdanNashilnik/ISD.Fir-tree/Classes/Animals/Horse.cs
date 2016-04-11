using ISD.Fir_tree.Interfaces;
using System;

namespace ISD.Fir_tree.Classes
{
    class Horse : Animal, IHarness
    {
        private ICart cart;

        public ICart Cart
        {
            get
            {
                return cart;
            }
        }

        public Horse(string name, Color color, Wooliness wool)
        {
            this.name = name;
            this.color = color;
            this.mood = Mood.Angry;
            this.bravery = Bravery.Brave;
            this.footWooliness = wool;
        }
        public Horse() : this("Безымяная лошадь", Color.Grey, Wooliness.Medium) { }

        public override void Move()
        {
            Console.WriteLine("Лошадь \"{0}\" скачет.", this.name);
            if ((this.cart != null) && (this.cart.WheelsType == WheelsType.Runners))
            {
                Snow.Squeak();
            }
        }
        public void PutCart(ICart cart)
        {
            Console.WriteLine("Лошадь \"{0}\" запрягли объектом \"{1}\".", this.name, cart.Name);
            this.cart = cart;
        }
        public void RemoveCart()
        {
            this.cart = null;
        }
    }
}
