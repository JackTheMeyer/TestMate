using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankMate;
using MateLibrary;

namespace BankMate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
            BankingSystem manager = new BankingSystem();
        }

        public static string CreateMessage()
        {
            return "Hello World";
        }
    }
}
