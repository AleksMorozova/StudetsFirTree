using Microsoft.VisualStudio.TestTools.UnitTesting;
using ISD.Fir_tree.Classes;
using static ISD.Fir_tree.Classes.Year;

namespace Tests
{
    [TestClass]
    public class FirstCouplet
    {
        Fir fir = new Fir();
        Oak oak = new Oak();
        Forest forest = new Forest();

        [TestInitialize]
        public void Init()
        {
            Year.OnSeasonChanged += new SeasonChanged((sender, e) => forest.ChangeSeason(((SeasonEventArgs)e).Season));
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
            Assert.AreEqual(Year.CurrentSeason, Season.Winter);

            Assert.AreEqual(fir.Color, Color.Green);
            Assert.AreEqual(fir.Constitution, TreeConstitution.Slim);
            Assert.AreEqual(oak.Color, Color.None);
            Assert.AreEqual(oak.Constitution, TreeConstitution.Fat);

            Year.ChangeSeason();
            Year.ChangeSeason();

            Assert.AreEqual(Year.CurrentSeason, Season.Summer);

            Assert.AreEqual(fir.Color, Color.Green);
            Assert.AreEqual(fir.Constitution, TreeConstitution.Slim);
            Assert.AreEqual(oak.Color, Color.Green);
            Assert.AreEqual(oak.Constitution, TreeConstitution.Fat);
        }
    }
}
