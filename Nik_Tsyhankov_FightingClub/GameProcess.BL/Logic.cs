using GameProcess.BL.Fighters;
using System;
using System.Collections.Generic;

namespace GameProcess.BL
{
    [Serializable]
    public class Logic : IFighting
    {
        public IFighter Player1 { get; private set; }
        public IFighter Player2 { get; private set; }
        public int Round { get; private set; }
        private static Random rnd;
        private List<string> _log = new List<string>();
        public List<string> Log
        {
            get { return _log; }
        }

        public Logic()
        {
            Player1 = new Player("NoName", ConstantFields.basicHp);
            Player2 = new Player("CPU", ConstantFields.basicHp);
            rnd = new Random();
            Round = 1;
        }

        public void MakeStep(BodyParts _part)
        {
            if (Round % 2 != 0)
            {
                Player2.SetBlock((BodyParts)rnd.Next(0, 4));
                Player2.GetHit(_part, ConstantFields.basicDamage);
            }
            else
            {
                Player1.SetBlock(_part);
                Player1.GetHit((BodyParts)rnd.Next(0, 4), ConstantFields.basicDamage);
            }
            Round++;
        }
        public void AddToLog(string item)
        {
            _log.Add(item);
        }
    }
}
