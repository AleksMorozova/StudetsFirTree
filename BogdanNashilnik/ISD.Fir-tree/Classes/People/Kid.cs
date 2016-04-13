using System;

namespace ISD.Fir_tree.Classes
{
    class Kid : Person
    {
        public bool Happy { get; private set; }

        public Kid() : base("Безымянный ребёнок", 10) { }

        public void MakeHappy()
        {
            this.Happy = true;
            Console.WriteLine("Теперь \"{0}\" счастлив.", this.name);
        }
    }
}
