using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Wolf:Animal, IAngry
    {
        public override void Move()
        {
            Console.WriteLine(" рысцою пробегал");
        }
    }
}
