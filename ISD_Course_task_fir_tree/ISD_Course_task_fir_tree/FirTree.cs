using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    class FirTree : Tree
    {
        private string name;
        private Colors color;
        private Waists waist;
        public string Name { get { return name; } }
        public Colors Color { get { return color; } }
        public Waists Waist { get { return waist; } }
        public FirTree(string name, Colors color, Waists waist)
        {
            this.name = name;
            this.color = color;
            this.waist = waist;
        }
        public void Grow(string frase) { Console.WriteLine(frase); }
    }
}
