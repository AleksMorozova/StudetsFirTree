using ISD.Fir_tree.Interfaces;
using System;

namespace ISD.Fir_tree.Classes
{
    class OldMan : Person
    {
        public OldMan() : base("Безымянный старик", 60) { }

        public FelledFir CutFir(Fir fir)
        {
            Console.WriteLine("Старик \"{0}\" срубил ёлку \"{1}\".", this.name, fir.Name);
            return (FelledFir)fir;
        }
        public FelledFir CutFirAtTheRoots(Fir fir)
        {
            Console.WriteLine("Старик \"{0}\" срубил ёлку \"{1}\" под корешок.", this.name, fir.Name);
            return (FelledFir)fir;
        }
    }
}
