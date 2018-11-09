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
            //Recieve Transfer Request

            // BankingSystem.Transfer(Sender, Reciever, Ammount
            
            //Account Located
            // BankingSystem.Locate(Reciever, Balance)
            Assert.AreEqual(Program.CreateMessage(), "Hello World");
        }
    }
}
