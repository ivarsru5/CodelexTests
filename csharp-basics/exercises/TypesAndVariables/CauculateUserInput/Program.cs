namespace CauculateUserInput;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine("Enter a series of single digit numbers (press Enter after each number).");
        Console.WriteLine("Enter a non-digit character to stop.");
        while (true)
        {
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number))
            {
                sum += number;
                Console.WriteLine($"Summ is {sum}");
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"Program stoped to execute and your total summ is {sum}");
    }
}

