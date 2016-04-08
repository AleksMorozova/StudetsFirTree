using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    class Forest
    {
        public List<Fir> firs = new List<Fir>();
        public Forest()
        {

            CreateTree();
        }
        public void CreateTree()
        {
            Console.Write("В лесу ");
            firs.Add(new Fir());
        }
        public void SeasonChanges()
        {
            Console.Write("В лесу ");
            for (int i = 0; i < firs.Count; i++)
            {
                firs[i].Grow();
            }

            Console.Write("Зимой и летом ");
            for (int i = 0; i < firs.Count; i++)
            {
                if (firs[i].IsSlim(Seasons.Summer).Equals(firs[i].IsSlim(Seasons.Winter)))
                {
                    Console.WriteLine("стройная,");
                }
                if (firs[i].GetColor(Seasons.Summer).Equals(firs[i].GetColor(Seasons.Winter)))
                {
                    Console.WriteLine("Зелёная была");
                }
            }
            
        }
    }
}
