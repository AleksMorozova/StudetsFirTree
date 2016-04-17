﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{     
    enum BodyParts {head, body, legs};

    [Serializable]
    class Player : IPlayer
    {          
        public string Name { get; set; }
        public BodyParts Blocked { get; set; }
        public int Hp { get; set; }        
        int Damage { get; set; }
        public bool Attacker { get; set; }
        public BodyParts Attacked { get; set; }

        public Player(Player loadPlayer)
        {
            this.Name = loadPlayer.Name;
            this.Hp = loadPlayer.Hp;
            this.Blocked = loadPlayer.Blocked;
            this.Attacker = loadPlayer.Attacker;
            this.Attacked = loadPlayer.Attacked;
            this.Damage = loadPlayer.Damage;
        }

        public Player(string name, int hp)
        {
            this.Name = name;
            this.Hp = hp;
            this.Attacker = true;
        }

        virtual public BodyParts ReturnAttackPartBody()
        {
            return Attacked;
        }

        virtual public void GetHit(BodyParts bodyPartAttack)
        {
            Attacked = bodyPartAttack;     
            if (bodyPartAttack == Blocked)
            {
                OnBlock();
            }
            else
                if (bodyPartAttack != Blocked)
                {
                    Hp--;
                    if (Hp > 0)
                    {
                        OnWound();
                    }
                    else
                    {
                        OnWound();
                        OnDeath();
                    }
                }
        }

        virtual public void SetBlock(BodyParts bodyPartBlock)
        {
            Blocked = bodyPartBlock;            
        }
              
        public event EventHandler<PlayerEventArgs> Block;
        public event EventHandler<PlayerEventArgs> Wound;
        public event EventHandler<PlayerEventArgs> Death;

        protected void OnBlock()
        {           
            if (Block != null)
            {
                Block(this, new PlayerEventArgs(this.Name, this.Hp));                
            }
        }

        protected void OnWound()
        {          
            if (Wound != null)
            {
                Wound(this, new PlayerEventArgs(this.Name, this.Hp));               
            }
        }

        protected void OnDeath()
        {
            if (Death != null)
            {
                Death(this, new PlayerEventArgs(this.Name, this.Hp));
            }
        }
        
    }
}
