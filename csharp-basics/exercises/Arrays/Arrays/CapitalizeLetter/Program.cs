namespace CapitalizeLetter;
class Program
{
    static void Main(string[] args)
    {
        string[] words = {"babana", "apple", "pear", "watermelon" };
        var capitalized = words.Select(word => char.ToUpper(word[0]) + word.Substring(1)).ToArray();
        Console.WriteLine(string.Join(",", words));
        Console.WriteLine(string.Join(",", capitalized));
    }
}

