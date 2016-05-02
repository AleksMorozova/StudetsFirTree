using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{  
    public interface IPlayer
    {
        string Name { get; set; }
        int HP { get; set; }
        bool Attacker { get; set; }
        BodyParts ReturnAttackPartBody();
        void GetHit(BodyParts bodyPartAttack);
        void SetBlock(BodyParts bodyPartBlock);
        event EventHandler<PlayerEventArgs> Block;
        event EventHandler<PlayerEventArgs> Wound;
        event EventHandler<PlayerEventArgs> Death;

        void Init(IPlayer player);
    }
}
