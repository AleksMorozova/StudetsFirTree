using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Horse:Animal, IHairy
    {
        public WoodSledge sledge;
        public override void Move()
        {
            Console.WriteLine(" торопится, бежит");
            if (sledge != null)
            {
                Console.WriteLine(" Везет лошадка дровенки");
            }
        }

    }
}
