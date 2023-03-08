using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year: ");
            var year = int.Parse(Console.ReadLine()!);
            Console.WriteLine("The century for year {0} is {1}", year, GetCentury(year));
        }

        static int GetCentury(int year)
        {
            return (year % 100 == 0) ? (year / 100) : (year / 100 + 1);
        }
    }
}
