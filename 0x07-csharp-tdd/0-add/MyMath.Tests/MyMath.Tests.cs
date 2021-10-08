using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(70, 0)]
        [TestCase(100, -30)]
        [TestCase(60, 10)]
        [TestCase(68, 2)]
        public void TestAdd(int val, int valb)
        {
            var result = MyMath.Operations.Add(val, valb);
            Assert.AreEqual(70, result);
        }
    }
}
