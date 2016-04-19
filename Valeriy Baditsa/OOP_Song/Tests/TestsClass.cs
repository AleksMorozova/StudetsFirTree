using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOP_Song
{
    [TestClass]
    public class TestsClass
    {
        Season season;
        Forest forest;
        ITree fir;
        ITree maple;

        [TestInitialize]
        public void Init()
        {
            season = new Season(Seasons.spring);
            forest = new Forest(season);
            fir = new Fir("test_Fir");
            maple = new Maple("test_Maple");
        }

        [TestMethod]
        public void TestReactionFirOnSezon_winter()
        {                        
            forest.AddTree(fir);
            season.OnSezonChanged(Seasons.winter);
            Assert.AreEqual(fir.color, Colors.green );
            Assert.AreEqual(fir.Figure, Figures.slender);
        }

        public void TestReactionFirOnSezon_summer()
        {
            forest.AddTree(fir);
            season.OnSezonChanged(Seasons.summer);
            Assert.AreEqual(fir.color, Colors.green);
            Assert.AreEqual(fir.Figure, Figures.slender);
        }

        [TestMethod]
        public void TestReactionMapleOnSezon_autumn()
        {                                    
            forest.AddTree(maple);
            season.OnSezonChanged(Seasons.autumn);
            Assert.AreEqual(maple.color, Colors.orange);
            Assert.AreEqual(maple.Figure, Figures.slender);
        }

        [TestMethod]
        public void TestReactionMapleOnSezon_summer()
        {
            forest.AddTree(maple);
            season.OnSezonChanged(Seasons.summer);
            Assert.AreEqual(maple.color, Colors.green);
            Assert.AreEqual(maple.Figure, Figures.standed);
        }

        [TestMethod]
        public void TestGrowingFir()
        {
            fir.Grow();
            Assert.AreEqual(fir.Hight, 3);
        }

        [TestMethod]
        public void TestGrowingMaple()
        {
            maple.Grow();
            Assert.AreEqual(maple.Hight, 10);
        }
    }
}
