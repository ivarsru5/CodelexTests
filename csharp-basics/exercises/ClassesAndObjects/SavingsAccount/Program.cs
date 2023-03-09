namespace SavingsAccount;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("How much money is in the account?: ");
        var startAmount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the annual interest rate:");
        var interestRate = Convert.ToInt32(Console.ReadLine());
        Console.Write("How long has the account been opened? ");
        var opened = Convert.ToInt32(Console.ReadLine());
        RunSimulation(startAmount, interestRate, opened);
    }

    static void RunSimulation(double startAmount, int interest, int opened)
    {
        var account = new SavingsAccount(startAmount);

        for (var index = 0; index < opened; index++)
        {
            Console.Write("Enter amount deposited for month: {0} :", index + 1);
            var deposited = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount withdrawn for: {0} : ", index + 1);
            var withdrawn = Convert.ToInt32(Console.ReadLine());
            account.AddMoney(deposited);
            account.Widraw(withdrawn);
            account.Interest(interest);
        }

        Console.WriteLine("Total deposit: {0}", account.totalDeposit);
        Console.WriteLine("Total withdrawn: {0}", account.totalWidraw);
        Console.WriteLine("Interest erned: {0}", account.totalInInterests);
        Console.WriteLine("Total balance: {0}", account.GetBalance());
    }
}

