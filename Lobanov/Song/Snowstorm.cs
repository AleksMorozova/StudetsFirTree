using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Snowstorm
    {

        public void Song(Fir fir)
        {
            Console.WriteLine("Метель ей пела песенку:");
            Console.WriteLine("«Спи, ёлочка, бай-бай!»");

            fir.IsSleep = true;
        }
    }
}
