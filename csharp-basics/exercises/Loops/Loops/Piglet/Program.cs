namespace Piglet;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Piglet!");
        var score = 0;
        var roll = 0;
        PlayGame(roll, score);
    }

    static void RollDice(int score)
    {
        Random number = new Random();
        var rolledNumber = number.Next(1,6);
    }

    static void PlayGame(int roll, int score)
    {
        while (roll != 1)
        {
            Random number = new Random();
            roll = number.Next(1, 7);

            Console.WriteLine("You rolled: {0}", roll);

            if (roll == 1)
            {
                Console.WriteLine("You rolled a 1. Your turn ends and you score 0 points.");
                score = 0;
                break;
            }
            else
            {
                score += roll;

                Console.WriteLine("Do you want to roll again? (y/n)");
                string input = Console.ReadLine()!;

                if (input.ToLower() == "n")
                {
                    Console.WriteLine($"Your final score is {score}.");
                    break;
                }
            }
        }

        Console.WriteLine("Thanks for playing Piglet!");
        Console.ReadKey();
    }
}

