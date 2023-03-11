using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "lear.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: The file does not exist.");
                return;
            }

            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lineCount++;

                    charCount += line.Length;

                    string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                }
            }

            Console.WriteLine("Line count: {0}", lineCount);
            Console.WriteLine("Word count: {0}", wordCount);
            Console.WriteLine("Character count: {0}", charCount);

            Console.ReadLine(); // pause at the end
        }
    }
}
