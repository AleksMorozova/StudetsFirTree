using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Song
{    
    interface IWildlife
    {
        string Name { get; set; }
        Colors color { get; }
        double Hight { get; set; }

        void Grow();
    }
}
