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

            
            Assert.AreEqual(a.GetSize(), 1);
            Assert.AreEqual(b.GetSize(), 1);
            Assert.AreEqual(oak.GetSize(), 1);

            myyear.ChangeSeason();

            Assert.AreEqual(myyear.CurrentSeason, Seasons.Winter);
            Assert.AreEqual(a.GetSize(), 3);
            Assert.AreEqual(b.GetSize(), 3);
            Assert.AreEqual(oak.GetSize(), 2);

            myyear.ChangeSeason();

            Assert.AreEqual(myyear.CurrentSeason, Seasons.Summer);
            Assert.AreEqual(a.GetSize(), 5);
            Assert.AreEqual(b.GetSize(), 5);
            Assert.AreEqual(oak.GetSize(), 3);

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

        [TestMethod]
        public void InstanceColorTest()
        {
            Song.Fir a = new Song.Fir();
            Fir b = new Fir();
            Oak oak = new Oak();

            Year myyear = new Year(Seasons.Summer);

            Assert.AreEqual(a.GetColor(myyear.CurrentSeason), Colors.Green);
            Assert.AreEqual(b.GetColor(myyear.CurrentSeason), Colors.Green);
            Assert.AreEqual(oak.GetColor(myyear.CurrentSeason), Colors.Green);

            myyear.ChangeSeason();
            Assert.AreEqual(a.GetColor(myyear.CurrentSeason), Colors.Green);
            Assert.AreEqual(b.GetColor(myyear.CurrentSeason), Colors.Green);
            Assert.AreEqual(oak.GetColor(myyear.CurrentSeason), Colors.Brown);
        }

        [TestMethod]
        public void EnviromentTest()
        {
            Frost fr = new Frost();
            Fir a = new Fir();
            Man man = new Man();

            Assert.AreEqual(a.Wrapped, false);
            fr.Freeze(a);
            Assert.AreEqual(a.Wrapped, true);

            Assert.AreEqual(a.Cutted, false);
            man.CutTheTree(a,CutType.Fully);
            Assert.AreEqual(a.Cutted, true);
        }
    }
}
