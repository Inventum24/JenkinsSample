using JenkinsSample.Lib;
using NUnit.Framework;

namespace JenkinsSample.LibTest
{
    [TestFixture]
    public class PackmanTest
    {


        private  Packman _packman;

        [SetUp]
        public void Setup()
        {
            _packman = new Packman("Silver");
        }

        [Test]
        public void TestDemo()
        {
            Assert.True(_packman.Name.Equals("Silver"));
        }
    }
}