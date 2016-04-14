using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISD.Fir_tree.Classes;

namespace Tests
{
    [TestClass]
    public class FirstCouplet
    {
        Fir fir = new Fir();
        Oak oak = new Oak();
        Year year = new Year();
        Forest forest;

        [TestInitialize]
        public void Init()
        {
            forest = new Forest(year);
            forest.Plant(fir);
            forest.Plant(oak);
        }
        [TestMethod]
        public void ForestPlantingTest()
        {
            Assert.AreEqual(forest.TreesCount, 2);
        }
        [TestMethod]
        public void GrowingTest()
        {
            Assert.AreEqual(fir.Age, 0);
            Assert.AreEqual(fir.Height, 0);
            Assert.AreEqual(oak.Age, 0);
            Assert.AreEqual(oak.Height, 0);

            forest.Grow(1);

            Assert.AreEqual(fir.Age, 1);
            Assert.AreEqual(fir.Height, 0.5);
            Assert.AreEqual(oak.Age, 1);
            Assert.AreEqual(oak.Height, 1);
        }
        [TestMethod]
        public void SeasonChangeTest()
        {
            Assert.AreEqual(year.CurrentSeason, Season.Winter);

            Assert.AreEqual(fir.Color, Color.Green);
            Assert.AreEqual(fir.Constitution, TreeConstitution.Slim);
            Assert.AreEqual(oak.Color, Color.None);
            Assert.AreEqual(oak.Constitution, TreeConstitution.Fat);

            year.NextSeason();
            year.NextSeason();

            Assert.AreEqual(year.CurrentSeason, Season.Summer);

            Assert.AreEqual(fir.Color, Color.Green);
            Assert.AreEqual(fir.Constitution, TreeConstitution.Slim);
            Assert.AreEqual(oak.Color, Color.Green);
            Assert.AreEqual(oak.Constitution, TreeConstitution.Fat);
        }
    }
}
