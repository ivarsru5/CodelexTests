namespace RollTwoDice;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter desired summ: ");
        var summ = int.Parse(Console.ReadLine()!);
        var diceOne = 0;
        var diceTwo = 0;
        RollDice(summ, diceOne, diceTwo);
    }

    static void RollDice(int summ, int diceOne, int diceTwo)
    {
        while ((diceOne + diceTwo) != summ)
        {
            Random roll = new Random();
            diceOne = roll.Next(1,7);
            diceTwo = roll.Next(1,7);
            Console.WriteLine("{0} and {1} = {2}", diceOne, diceTwo, diceTwo+diceOne);
        }
    }
}

