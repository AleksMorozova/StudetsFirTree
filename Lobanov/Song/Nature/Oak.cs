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
            return Colors.Brown;
        }

        public override void Grow()
        {
            size++;
        }
    }
}
