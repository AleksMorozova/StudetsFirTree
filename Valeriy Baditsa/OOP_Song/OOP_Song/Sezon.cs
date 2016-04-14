using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Song
{
    class Sezon
    {
        public Sezons CurrentSezon { get; set; }
        double Temperature {get; set; }

        public Sezon(Sezons currentSezon)
        {
            this.CurrentSezon = currentSezon;
            Console.WriteLine("Setted sezon = {0}", this.CurrentSezon);
        }

        public event EventHandler<SezonEventArgs> SezonChanged;

        public void OnSezonChanged(Sezons changedSezonName)
        {            
            Console.WriteLine("Sezon is changed");
            if (SezonChanged != null)
            {
                SezonChanged(this, new SezonEventArgs(changedSezonName));                
            }
        }
    }
}
