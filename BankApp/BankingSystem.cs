using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateLibrary
{
    public class BankingSystem
    {
        private List<User> _userList = new List<User>();
        public BankingSystem()
        {
            
        }

        public List<User> Users
        {
            get
            {
                return _userList;
            }
        }
 
        public void TransferComplete()
        {

        }

        public void Transfer(Account sender, Account reciever, double amount)
        {

        }

        public void Locate(Account reciever)
        {

        }
       
    }
}
