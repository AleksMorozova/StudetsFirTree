using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
   public class Hare:Animal
    {


        public override Character GetAnimalCharacter()
        {
            return Character.Coward;
        }
        public Colors GetColor(Seasons season)
        {
            return Colors.Grey;
        }
        public override void Move()
        {
            Console.WriteLine(" скакал");
        }
        public void JumpUnderTheTree()
        {
            Console.Write("Под ёлочкой");
            Move();
        }
    }
}
