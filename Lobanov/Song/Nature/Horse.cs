using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
   public class Horse:Animal
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
        public override bool IsHairy()
        {
            return true;
        }

    }
}
