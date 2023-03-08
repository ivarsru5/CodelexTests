namespace CauculateDistance;
class Program
{
    static void Main(string[] args)
    {
        //Not the best way to parse input as it could be not numeric data.
        //But in this exercise I force unwrap values because I will provide numeric values.
        Console.Write("Input distance in meters:");
        int distance = int.Parse(Console.ReadLine()!);
        Console.Write("Input hours:");
        int hours = int.Parse(Console.ReadLine()!);
        Console.Write("Input minutes:");
        int minutes = int.Parse(Console.ReadLine()!);
        Console.Write("Input seconds:");
        int seconds = int.Parse(Console.ReadLine()!);

        Cauculate(distance, hours, minutes, seconds);
    }

    static void Cauculate(int distance, int hours, int minutes, int seconds)
    {
        var totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
        var metersPerSecond = distance / totalSeconds;
        var kilometersPerHour = (distance / 1000.0) / (totalSeconds / 3600.0);
        var milesPerHour = (distance / 1609.0) / (totalSeconds / 3600.0);
        Console.WriteLine("Speed:");
        Console.WriteLine("{0} meters/second", metersPerSecond);
        Console.WriteLine("{0} kilometers/hour", kilometersPerHour);
        Console.WriteLine("{0} miles/hour", milesPerHour);
    }
}

