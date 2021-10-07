using Microsoft.VisualStudio.TestTools.UnitTesting;
using testapp;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 0;
            StuffToTest.addSomthing(ref x);
            Assert.IsTrue(x == 1);
        }
    }
}
