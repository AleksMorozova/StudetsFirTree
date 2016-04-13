﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FightClubLogic.Tests
{
    [TestClass()]
    public class BattleTests
    {
        [TestMethod()]
        public void BattleTest()
        {
            Fighter f1 = new Fighter("123", 15, 5);
            Fighter f2 = new Fighter("abc", 25, 10);
            Battle battle = new Battle(f1, f2);

            Assert.AreEqual(f1, battle.Fighter1);
            Assert.AreEqual(f2, battle.Fighter2);
            Assert.AreEqual(battle.Round, 1);
            Assert.AreEqual(battle.RoundHalf, RoundHalf.HumanAttack);
        }

        [TestMethod()]
        public void ActionTest()
        {
            bool headGenerated = false;
            bool bodyGenerated = false;
            bool legsGenerated = false;
            do
            {
                Fighter f1 = new Fighter("123", 15, 5);
                Fighter f2 = new Fighter("123", 15, 5);
                Battle battle = new Battle(f1, f2);
                battle.Action(BodyPart.Head);
                if (battle.Fighter2.Blocked == BodyPart.Head)
                {
                    Assert.AreEqual(battle.Fighter2.HP, 15);
                    headGenerated = true;
                }
                else if (battle.Fighter2.Blocked == BodyPart.Body)
                {
                    Assert.AreEqual(battle.Fighter2.HP, 10);
                    bodyGenerated = true;
                }
                else
                {
                    Assert.AreEqual(battle.Fighter2.HP, 10);
                    legsGenerated = true;
                }
            } while (!(headGenerated && bodyGenerated && legsGenerated));
        }
        [TestMethod()]
        public void BattleCanEnd()
        {
            Fighter f1 = new Fighter("123", 15, 5);
            Fighter f2 = new Fighter("123", 15, 5);
            Battle battle = new Battle(f1, f2);

            bool eventRecieved = false;
            battle.Fighter1.Death += delegate (object sender, EventArgs e)
            {
                eventRecieved = true;
            };
            battle.Fighter2.Death += delegate (object sender, EventArgs e)
            {
                eventRecieved = true;
            };

            while (!eventRecieved)
            {
                battle.Action(BodyPart.Head);
            }
            Assert.AreEqual(eventRecieved, true);
        }
    }
}