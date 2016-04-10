using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSong
{
    interface INature
    {
        string Name { get; set; }
        int High { get; set; }
        int Location { get; set; }
        int State();
        Colors ReactionOnSezon(Sezon sezon); 
    }
}
