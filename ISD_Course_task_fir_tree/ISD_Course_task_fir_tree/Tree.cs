using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_Course_task_fir_tree
{
    interface Tree
    {
        Colors Color { get; }
        Waists Waist { get; }
        void Grow(string frase);
    }
}
