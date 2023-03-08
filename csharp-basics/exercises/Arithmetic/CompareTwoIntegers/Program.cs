namespace CompareTwoIntegers;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter first number: ");
        var first = int.Parse(Console.ReadLine()!);
        Console.Write("Please enter second number: ");
        var second = int.Parse(Console.ReadLine()!);

        var result = Compare(first, second);
        Console.WriteLine("Input numbers generate result -> {0}", result);
    }

    static bool Compare(int first, int second)
    {
        var add = first + second;
        var difference = first - second;
        if (first == 15 || second == 15)
        {
            return true;
        } else if(add == 15 || difference == 15)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

