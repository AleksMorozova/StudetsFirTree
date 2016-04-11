using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song
{
    interface ICuttable
    {
        bool Cutted { get;  }
        void Cut(CutType type);
    }
}
