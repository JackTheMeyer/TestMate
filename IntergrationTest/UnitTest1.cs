using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankMate;

namespace BankMate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTransfer()
        {
            Assert.AreEqual(Program.CreateMessage(), "Hello World");
        }
    }
}
