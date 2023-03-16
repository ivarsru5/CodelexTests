namespace RandomNumberFinder;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Whitch position you want to know: ");
        var position = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Element at index: {0} is {1}", position, FindIndex(position));
    }

    private static int FindIndex(int atIndex)
    {
        var index = atIndex - 1;
        var array = Enumerable.Range(1, 20).ToArray();
        var number = array[index];

        return number;
    }
}

