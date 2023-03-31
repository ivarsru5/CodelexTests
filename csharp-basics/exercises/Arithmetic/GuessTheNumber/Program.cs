namespace GuessTheNumber;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("I'm thinking of a number between 1-100.  Try to guess it.");
        var userNumber = int.Parse(Console.ReadLine()!);
        var result = ChackInput(userNumber);
        Console.WriteLine(result);
    }

    static string ChackInput(int input)
    {
        var random = new Random();
        var randomNumber = random.Next(1, 100);

        if (input == randomNumber)
        {
            return "You are correct, I guessed" + randomNumber;
        }
        else if (input > randomNumber)
        {
            return "You guessed to high, I was thinking of: " + randomNumber;
        }
        else
        {
            return "You guessed to low, I was thinking of: " + randomNumber;
        }
    }
}

