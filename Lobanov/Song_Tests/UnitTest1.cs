using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Song;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GrowTest()
        {
            Year myyear = new Year(Seasons.Summer);
            Song.Fir a = new Song.Fir();
            Fir b = new Fir();
            Oak oak = new Oak();

            Forest forest = new Forest(myyear);
            forest.AddTree(a); forest.AddTree(b); forest.AddTree(oak);

            Assert.AreEqual(forest.Trees.Count, 3);
            Assert.AreEqual(forest.Trees[0].GetSize(), 1);
            Assert.AreEqual(forest.Trees[1].GetSize(), 1);
            Assert.AreEqual(forest.Trees[2].GetSize(), 1);

            myyear.ChangeSeason();

            Assert.AreEqual(myyear.CurrentSeason, Seasons.Winter);
            Assert.AreEqual(forest.Trees[0].GetSize(), 3);
            Assert.AreEqual(forest.Trees[1].GetSize(), 3);
            Assert.AreEqual(forest.Trees[2].GetSize(), 2);

            myyear.ChangeSeason();

            Assert.AreEqual(myyear.CurrentSeason, Seasons.Summer);
            Assert.AreEqual(forest.Trees[0].GetSize(), 5);
            Assert.AreEqual(forest.Trees[1].GetSize(), 5);
            Assert.AreEqual(forest.Trees[2].GetSize(), 3);

        }
        [TestMethod]
        public void CharactersTest()
        {
            Hare hare = new Hare();
            Wolf wolf = new Wolf();
            Horse horse = new Horse();

            Assert.AreEqual(hare.IsHairy(), false);
            Assert.AreEqual(wolf.IsHairy(), false);
            Assert.AreEqual(horse.IsHairy(), true);

            Assert.AreEqual(hare.GetAnimalCharacter(),Character.Coward);
            Assert.AreEqual(wolf.GetAnimalCharacter(), Character.Angry);
            Assert.AreEqual(horse.GetAnimalCharacter(), Character.None);
        }
    }
}
