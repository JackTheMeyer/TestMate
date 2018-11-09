using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankMate;

namespace BankMate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.CreateMessage(), "Hello World");
        }
    }
}
