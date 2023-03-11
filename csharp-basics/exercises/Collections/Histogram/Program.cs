using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "midtermscores.txt";

        static void Main(string[] args)
        {
            var receivedScores = GetScores(Path);
            SortScores(receivedScores);
        }

        static List<int> GetScores(string path)
        {
            List<int> scores = new List<int>();
            var readScores = File.ReadAllLines(path);
            foreach (var line in readScores)
            {
                var receivedScores = line.Split(' ');
                scores.AddRange(receivedScores.Select(s => Convert.ToInt32(s)));
            }
            return scores;
        }

        static void SortScores(List<int> scores)
        {
            Dictionary<string, int> table = new Dictionary<string, int>();
            foreach (var score in scores)
            {
                int range = score / 10 * 10;
                if (!table.ContainsKey($"{range:00}-{range + 9:00}"))
                {
                    table[$"{range:00}-{range + 9:00}"] = 1;
                }
                else
                {
                    table[$"{range:00}-{range + 9:00}"]++;
                }
            }
            DisplayHistogram(table.OrderBy(x => x.Key).ToDictionary(obj => obj.Key, obj => obj.Value));
        }

        static void DisplayHistogram(Dictionary<string, int> table)
        {
            foreach (var pair in table)
            {
                Console.Write($"{pair.Key}: ");
                for (int i = 0; i < pair.Value; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
