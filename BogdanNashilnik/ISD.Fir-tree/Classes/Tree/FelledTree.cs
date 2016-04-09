using ISD.Fir_tree.Interfaces;

namespace ISD.Fir_tree.Classes
{
    abstract class FelledTree : INamed
    {
        protected string name;
        
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
