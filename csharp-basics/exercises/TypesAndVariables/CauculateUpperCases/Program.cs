namespace CauculateUpperCases;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your string data: ");
        var userString = Console.ReadLine();
        var result = CauculateUpperCase(userString ?? "");
        Console.WriteLine($"This string contains {result} upper characters!");
    }

    static int CauculateUpperCase(string input)
    {
        int times = 0;
        var charArray = input.ToCharArray();
        foreach(char data in charArray)
        {
            if (Char.IsUpper(data)){
                times += 1;
            }
        }
        return times;
    }
}

