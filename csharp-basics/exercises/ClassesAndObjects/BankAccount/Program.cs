using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("BenBen", "Benson", -1117.25356356);
            Console.WriteLine(account.GetUser());
        }
    }
}
