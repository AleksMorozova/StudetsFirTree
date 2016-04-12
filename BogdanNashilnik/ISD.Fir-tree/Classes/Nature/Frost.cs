using ISD.Fir_tree.Interfaces;
using System;

namespace ISD.Fir_tree.Classes
{
    class Frost : IHaveName
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Frost(string name)
        {
            this.name = name;
        }
        public Frost() : this("Безымянный мороз") { }

        public void WrapWithSnow(ISnowed obj)
        {
            obj.WrappedWithSnow = true;
            Console.WriteLine("Мороз \"{0}\" укутал снегом \"{1}\".", this.name, obj.Name);
            this.Say("Укутав снегом, мороз добавил: \"Смотри, не замерзай!\".");
        }
        public void Say(string text)
        {
            Console.WriteLine(text);
        }
    }
}
