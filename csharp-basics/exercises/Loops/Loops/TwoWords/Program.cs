namespace TwoWords;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first word:");
        var first = Console.ReadLine()!;
        Console.WriteLine("Enter second word");
        var second = Console.ReadLine()!;

        var indexCount = 30 - (first.Length + second.Length);

        Console.Write(first);
        for (var index = 0; index < indexCount; index++)
        {
            Console.Write(".");
        }
        Console.Write(second);
    }
}

