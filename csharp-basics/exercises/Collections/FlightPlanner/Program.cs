using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "/Users/ivars_rug/Desktop/CodelexTests/csharp-basics/exercises/Collections/FlightPlanner/flights.txt";

        private static void Main(string[] args)
        {
            HashSet<string> cities = GetCities(Path);

            Console.WriteLine("What would you like to do: ");
            Console.WriteLine("To display list of the cities press 1 or # to exit: ");
            var n = Console.ReadKey().KeyChar;

            if (n == '1')
            {
                var start = SelectStartCity(cities);
                var destanation = SelectDestanation(cities, start);
                Console.WriteLine("Round trip from {0} to {1} and back to {0} selected!", start, destanation);
            }
            else if (n == '#')
            {
                System.Environment.Exit(1);
            }
        }

        static HashSet<string> GetCities(string path)
        {
            HashSet<string> cities = new HashSet<string>();
            var readText = File.ReadAllLines(path);

            foreach (var s in readText)
            {
                var result = s.Split(" -> ");
                cities.Add(result[0]);
                cities.Add(result[1]);
            }
            return cities;
        }

        static string SelectStartCity(HashSet<string> cities)
        {
            var dict = cities.Select((city, index) => new { Index = index + 1, City = city }).ToDictionary(x => x.Index, x => x.City);

            foreach (var pair in dict)
                Console.WriteLine("{0}:{1}", pair.Key, pair.Value);

            Console.WriteLine("Select city: ");
            var selectedChar = Console.ReadKey().KeyChar;
            int selectedInt = int.Parse(selectedChar.ToString());

            return dict[selectedInt];
        }

        static string SelectDestanation(HashSet<string> cities, string startPoint)
        {
            var destanations = cities
                .Where(x => x != startPoint)
                .Select((city, index) => new { Index = index + 1, City = city })
                .ToDictionary(x => x.Index, x => x.City);

            foreach (var destanation in destanations)
                Console.WriteLine("{0}:{1}", destanation.Key, destanation.Value);

            Console.WriteLine("Select destenation: ");
            var selectedChar = Console.ReadKey().KeyChar;
            int selectedInt = int.Parse(selectedChar.ToString());

            return destanations[selectedInt];
        }
    }
}
