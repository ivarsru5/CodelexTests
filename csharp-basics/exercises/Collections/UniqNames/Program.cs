namespace UniqNames;
class Program
{
    static void Main(string[] args)
    {
        HashSet<string> names = new HashSet<string>();

        while (true)
        {
            Console.Write("Enter name: ");
            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
                break;

            names.Add(name!);
        }
        foreach (var name in names)
            Console.Write($"{name}, ");
    }
}

