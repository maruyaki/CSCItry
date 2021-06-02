using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSCItryTest.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calculation = new CSCItry.console.Objects.Caluculater();
            int result = calculation.Add(3, 5);
            Assert.AreEqual(8, result);
        }
    }
}
