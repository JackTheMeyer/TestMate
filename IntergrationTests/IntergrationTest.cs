using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankMate;
using MateLibrary;

namespace BankMate
{
    [TestClass]
    public class UnitTest1
    {
        BankingSystem banker = new BankingSystem();
        User user = new User("Jack", "password");

        
        [TestMethod]
        public void TestTransfer()
        {
            // Mock Data
            string accountNumber = "1234";
            Account reciever = new Account(accountNumber);
            Account sender = new Account(accountNumber);
            double amount = 21.00;
            double balance = 100.00;
           
            // Test if transfer was completed succesfully
            banker.TransferComplete();
            
            // Test if banker correctly located the reciever account
            banker.Locate(reciever);
            
            // Test banker can create a debit and credit transaction on the appropriate accounts for the specified amount
            banker.Transfer(sender, reciever, amount);
            
            // Test if User can Open Account
            user.OpenAccount(accountNumber, balance);

            // Test if user can start a transfer request
            user.SendTransfer(sender, reciever, balance); 

            Assert.AreEqual(Program.CreateMessage(), "Hello World");
        }
    }
}
