using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public class Frost
    {
        public void Freeze(Fir fir)
        {
            fir.Wrapped = true;
            fir.Freeze();
        }
    }
}
