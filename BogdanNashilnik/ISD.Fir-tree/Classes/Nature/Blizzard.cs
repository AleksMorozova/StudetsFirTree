using ISD.Fir_tree.Interfaces;
using System;

namespace ISD.Fir_tree.Classes
{
    class Blizzard : IHaveName
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Blizzard(string name)
        {
            this.name = name;
        }
        public Blizzard() : this("Безымянная метель.") { }

        public void Sing(Song song, params IHaveName[] listeners)
        {
            foreach (var listener in listeners)
            {
                Console.WriteLine("Метель \"{0}\" поёт песню для \"{1}\":", this.name, listener.Name);
            }
            Console.WriteLine(song.Text);
        }
    }
}
