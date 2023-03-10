using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var account = new Account("Barto's", 100);
            Console.WriteLine("Account: {0}", account.ToString());
            account.Deposit(20);
            Console.WriteLine("Account after deposit: {0}", account.ToString());

            var matAccount = new Account("Mat", 1000);
            var myAccount = new Account("MyAccount", 0);

            Account.Transfer(matAccount, myAccount, 100);

            Console.WriteLine("Account: {0}", matAccount.ToString());
            Console.WriteLine("Account: {0}", myAccount.ToString());
        }
    }
}
