using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class WoodSledge
    {
        public Man peasant;
        
        public Runners runners = new Runners();

        public bool IsControlled()
        {
            if (peasant != null)
            {
                return true;
            }
            else return false;
        }

    }
}
