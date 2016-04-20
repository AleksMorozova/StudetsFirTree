using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public class Oak: Tree
    {
        public Oak()
        {
            
        }

        public override bool IsSlim(Seasons season)
        {
            return false;
        }

        public override Colors GetColor(Seasons season)
        {
            if (season == Seasons.Winter)
            {
                return Colors.Brown;
            }
            else
            {
                return Colors.Green;
            }
        }

        public override void Grow()
        {
            size++;
        }
    }
}
