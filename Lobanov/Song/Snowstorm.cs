using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Snowstorm
    {

        public void Song(Fir fir, string text)
        {
            Console.WriteLine(text);
            fir.IsSleep = true;
        }
    }
}
