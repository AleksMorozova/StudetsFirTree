using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSong
{
    enum Colors {green, yellow}
    class Fir : Tree
    {
        public Colors Color;
        
        public override event EventHandler Born;
        public void OnBorn()
        {
            if (Born != null)
            {
                Born(this, EventArgs.Empty);
                this.High = 0;
                 this.Color= Colors.green;        
            }
        }       

        public override event EventHandler Grow;
        public override int State()
        {
            return High;
        }

        public override void ProcessGrow()
        {
            this.High++;
            if (Grow != null)
                Grow(this, EventArgs.Empty);
        }

        public override event EventHandler ReactionOnSeazon;
        public override Colors ReactionOnSezon(Sezon sezon)
        {                       
            if (ReactionOnSeazon != null)
                ReactionOnSeazon(this, EventArgs.Empty);
            return Color;
        }

       
    }
}
