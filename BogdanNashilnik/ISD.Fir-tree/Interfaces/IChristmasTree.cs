using ISD.Fir_tree.Classes;
using System.Collections.Generic;

namespace ISD.Fir_tree.Interfaces
{
    interface IChristmasTree : IHaveName
    {
        List<ChristmasTreeToy> Decorations { get; }
        void Decorate(ChristmasTreeToy decoration);
        bool Fancy { get; }
    }
}
