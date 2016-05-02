using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CombatClub
{
    public interface IMainForm
    {
        ProgressBar ProgressBar_Player { get; }
        ProgressBar ProgressBar_CompName { get; }
        
        void SetBinding(IPlayer player, IPlayer comp);
                
        void buttonText(string text);
        bool buttonVisible {set; }
        
        string LstBox { set; }
        
        event EventHandler HeadClick;
        event EventHandler BodyClick;
        event EventHandler LegsClick;
        event EventHandler newGameToolStripMenuItemClick;
        event EventHandler loadGameToolStripMenuItemClick;
        event EventHandler saveGameToolStripMenuItemClick;
    }
}

