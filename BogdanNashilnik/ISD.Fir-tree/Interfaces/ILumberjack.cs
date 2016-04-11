using ISD.Fir_tree.Classes;

namespace ISD.Fir_tree.Interfaces
{
    interface ILumberjack
    {
        FelledFir CutFirAtTheRoots(Fir fir);
        FelledFir CutFir(Fir fir);
    }
}
