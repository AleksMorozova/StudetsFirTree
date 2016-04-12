using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    abstract class Animal
    {
        public virtual Character GetAnimalCharacter()
        {
            return Character.None;
        }
        public virtual bool IsHairy()
        {
            return false;
        }
        public virtual void Move()
        {
            Console.WriteLine("перемещается");
        }
    }
}
