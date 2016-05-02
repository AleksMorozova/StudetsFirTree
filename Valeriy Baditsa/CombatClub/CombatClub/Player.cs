using System;
using System.ComponentModel;

namespace CombatClub
{     
    public enum BodyParts {head, body, legs};

    [Serializable]
     class Player : IPlayer , INotifyPropertyChanged
    {
        string name;
        public string Name 
        {
            get { return name; }
            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }
        public BodyParts Blocked { get; set; }
        private int Hp;
        public int HP
        {
            get { return  Hp; }
            set
            {
                if (value != this.Hp)
                {
                    this.Hp = value;
                    NotifyPropertyChanged("Hp");
                }
            }
        }        
        int Damage { get; set; }
        public bool Attacker { get; set; }
        public BodyParts Attacked { get; set; }

        public Player(Player loadPlayer)
        {
            this.name = loadPlayer.name;
            this.HP = loadPlayer.Hp;
            this.Blocked = loadPlayer.Blocked;
            this.Attacker = loadPlayer.Attacker;
            this.Attacked = loadPlayer.Attacked;
            this.Damage = loadPlayer.Damage;
        }

        public Player() { }

        public void Init(IPlayer player)
        {            
            this.Attacker = player.Attacker;
            this.Name = player.Name;
            this.HP = player.HP;
        }

        public Player(string name, int hp)
        {
            this.Name = name;
            this.Hp = hp;
            this.Attacker = true;
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
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
                    HP--;
                    if (HP   > 0)
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
