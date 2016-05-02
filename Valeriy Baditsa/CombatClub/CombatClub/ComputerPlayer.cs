using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatClub
{
    [Serializable]
    class  ComputerPlayer : Player
    {        
        private Random rndm = new Random();
        private int numberBodyPart;

        public ComputerPlayer(Player loadPlayer)
            : base(loadPlayer)
        { }

        public ComputerPlayer()
            : base()
        { }

        public ComputerPlayer(string name, int hp) 
             : base (name, hp)
        {            
                        
        }
        
        override public void GetHit(BodyParts bodyPart)             
        {
            bodyPart = RandomBodyPart();
            base.GetHit(bodyPart);                        
        }
        public BodyParts testc()
        {
            return BodyParts.body;
        }

        public override BodyParts ReturnAttackPartBody()
        {
            this.Attacked = RandomBodyPart();
            return this.Attacked;
        }

        public BodyParts RandomBodyPart()
        {
            numberBodyPart = rndm.Next(3);
            Attacked = (BodyParts)numberBodyPart;
            return Attacked;
        }
        
        public override void SetBlock(BodyParts bodyPart)
        {
            bodyPart = RandomBodyPart();
            base.SetBlock(bodyPart);            
        }
    }
}
