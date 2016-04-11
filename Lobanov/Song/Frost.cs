using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Frost
    {
        public void Freeze(Fir fir)
        {

            
            Console.WriteLine("Мороз её укутывал, ");
            fir.Wrapped = true;
            Console.Write("Смотри, ");
            fir.Freeze();
        }
    }
}
