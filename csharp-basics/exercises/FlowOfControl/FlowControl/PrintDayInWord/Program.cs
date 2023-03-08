namespace PrintDayInWord;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter day number: ");
        var day = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Your selected day: {0}", FindDay(day));
    }

    static string FindDay(int day)
    {
        switch (day)
        {
            case 0:
                return "Monday";
            case 1:
                return "Tuesday";
            case 2:
                return "Wednesday";
            case 3:
                return "Thursday";
            case 4:
                return "Friday";
            case 5:
                return "Saturday";
            case 6:
                return "Sunday";
            default:
                return "There is no such day";
        }
    }
}

