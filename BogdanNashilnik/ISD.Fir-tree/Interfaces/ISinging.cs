using ISD.Fir_tree.Classes;

namespace ISD.Fir_tree.Interfaces
{
    interface ISinging
    {
        void Sing(Song song, params INamed[] listeners);
    }
}
