using NUnit.Framework;
using testapp;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int x = 0;
            StuffToTest.addSomthing(ref x);
            Assert.IsTrue(x == 1);
        }
    }
}