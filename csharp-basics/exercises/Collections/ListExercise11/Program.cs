using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            List<string> strElements = new List<string>();

            //TODO: Add 10 values to list
            for (var index = 0; index <= 10; index++)
            {
                strElements.Add(index.ToString());
            }

            //TODO: Add new value at 5th position
            strElements[4] = "11";

            //TODO: Change value at last position (Calculate last position programmatically)
            var elements = strElements.Count;
            strElements[elements - 1] = "13";

            //TODO: Sort your list in alphabetical order
            strElements = strElements.OrderBy(x => x).ToList();

            //TODO: Check if your list contains "Foobar" element
            strElements.Contains("Foobar");

            //TODO: Print each element of list using loop
            foreach (var element in strElements)
                Console.WriteLine(element);
        }
    }
}
