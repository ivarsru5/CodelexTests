namespace EvenOrOdd;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your number:");
        var inputNumber = int.Parse(Console.ReadLine()!);
        Console.WriteLine(Cauculate(inputNumber));
        Console.WriteLine("Bye");
    }

    static string Cauculate(int number)
    {
        if (number % 2 == 0)
        {
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
}

