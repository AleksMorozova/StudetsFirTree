using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    public class Forest
    {
        protected List<Tree> Trees{get;private set;}
        protected List<Animal> Chars { get; private set; } 

        public Forest(ISeasonProvider year)
        {
            year.OnSeasonChanged += YearChangedSeason;
            Trees = new List<Tree>();
            Chars = new List<Animal>();
            
        }

        private void YearChangedSeason(object sender, SeasonEventArgs e)
        {
            for (int i = 0; i < Trees.Count; i++)
            {
                Trees[i].SeasonHandler(e);
            }
        }

        public void AddTree(Tree input)
        {
            Trees.Add(input);
        }
        public void AddAnimal(Animal input)
        {
            Chars.Add(input);
        }
        
            
        
    }
}
