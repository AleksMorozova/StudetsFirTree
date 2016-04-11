using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSong
{
    abstract class Tree : INature
    {
        public string Name { get; set; }
        public int High { get; set; }
        public int Location { get; set; }

        public abstract int State();
        abstract public void ProcessGrow();

        public virtual event EventHandler Born;
        public virtual event EventHandler Grow;
        public virtual event EventHandler ReactionOnSeazon;

        public abstract Colors ReactionOnSezon(Sezon sezon);        
    }
}
