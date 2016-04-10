using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSong
{
    class Forest : Place
    {        
        public string Name { get; set; }
        public List<INature> natureList = new List<INature>();

        public override void CheckStateAllNature()
        {
            foreach (INature nat in natureList)
            {
                nat.State();
            }
        }

        public override void AddNature(INature nature)
        {            
            natureList.Add(nature);
        }

        public override void AddSezon(Sezon sezon)
        {
            foreach (INature nat in natureList)
            {
                nat.ReactionOnSezon(sezon);
            }
        }
    }
}
