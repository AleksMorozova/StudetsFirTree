using System.Collections.Generic;

namespace ISD.Fir_tree.Interfaces
{
    interface IChristmasTree : IFancy, INamed
    {
        List<ITreeDecorator> Decorations { get; }
        void Decorate(ITreeDecorator decoration);
    }
}
