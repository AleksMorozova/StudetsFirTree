using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public class Wolf:Animal
    {
        public override Character GetAnimalCharacter()
        {
            return Character.Angry;
        }
        public Wolf()
        {

        }
        public override void Move()
        {
            Console.WriteLine(" рысцою пробегал");
        }
    }
}
