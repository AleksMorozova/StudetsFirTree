using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Song
{
    public class SezonEventArgs : EventArgs
    {
        public Sezons CurrentSezon { get; set; }
        public double Temperature { get; set; }

        public SezonEventArgs(Sezons sezon)
        {
            this.CurrentSezon = sezon;
        }
    }
}
