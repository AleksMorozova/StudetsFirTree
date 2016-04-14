using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Song
{
    interface ITree : IWildlife 
    {                        
        Figures Figure { get; }               
        void reactionsTreesOn_SezonChanged(object sender, SezonEventArgs e);
    }
}
