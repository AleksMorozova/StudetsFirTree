using NUnit.Framework;
using Spruce.Props;
using Spruce.Trees;

namespace Spruce.Test
{
    [TestFixture]
    public class Test
    {
        private ISeasonChanger _year;
        private Forest _forest;
        private IPlant _spruce;
        private IPlant _oak;


        [SetUp]
        public void Init()
        {
            _year = new Year();
            _forest = new Forest(_year);
            _spruce = new Spruce();
            _oak = new Oak();

            _forest.AddTree(_spruce);
            _forest.AddTree(_oak);
        }

        [Test]
        public void PlantTesting_Growing()
        {
            _year.ChangeMonth();

            Assert.That(_spruce.Hight, Is.EqualTo(10));
            Assert.That(_oak.Hight, Is.EqualTo(10));
        }

        [Test]
        public void OakTesting_AppearanceChanged()
        {
            for(int i = 0; i < 5; i++)
                _year.ChangeMonth();

            Assert.That(_oak.Color, Is.Not.EqualTo(Colors.None));
            Assert.That(_oak.Appearance, Is.Not.EqualTo(Appearances.Skinny));
        }

        [Test]
        [Repeat(10)]
        public void SpruceTesting_AppearanceChanged()
        {
            _year.ChangeMonth();

            Assert.That(_spruce.Color, Is.EqualTo(Colors.Green));
            Assert.That(_spruce.Appearance, Is.EqualTo(Appearances.Slim));
        }
    }
}
