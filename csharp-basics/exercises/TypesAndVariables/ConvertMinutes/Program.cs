namespace ConvertMinutes;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter minute count:");
        var minutes = int.Parse(Console.ReadLine()!);
        Convert(minutes);
    }

    static void Convert(int minutes)
    {
        var minutesInDay = 60 * 24;
        var minutesInYear = 365 * minutesInDay;
        var totalDays = minutes / minutesInDay;
        var totalYears = totalDays / 365;
        var remainingDays = totalDays % 365;

        Console.WriteLine("{0} minutes is equivalent to {1} years and {2} days.", minutes, totalYears, remainingDays);
    }
}

