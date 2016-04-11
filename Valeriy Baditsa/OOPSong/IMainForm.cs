using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSong
{
    interface IMainForm
    {
        void ListBoxAddItem(string item);  
        event EventHandler buttonPlaySongClick;
    }
}
