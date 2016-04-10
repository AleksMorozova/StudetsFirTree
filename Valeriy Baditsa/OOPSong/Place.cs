using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSong
{
    abstract class Place
    {
        string Name { get; set; }
        List<INature> natureList;
        public abstract void CheckStateAllNature();        
        public abstract void AddNature(INature nature);
        public abstract void AddSezon(Sezon sezon);
    }
}
