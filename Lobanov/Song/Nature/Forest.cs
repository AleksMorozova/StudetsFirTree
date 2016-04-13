using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Forest
    {
        public List<Tree> Trees{get;private set;}
        public List<Animal> Chars { get; private set; } 

        public Forest()
        {
            Trees = new List<Tree>();
            Chars = new List<Animal>();
        }
        public void AddTree(Tree input)
        {
            Trees.Add(input);
        }
        public void AddAnimal(Animal input)
        {
            Chars.Add(input);
        }
        public void SeasonChanges()
        {
            for (int i = 0; i < Trees.Count; i++)
            {
                Trees[i].Grow();
            }
        }
    }
}
