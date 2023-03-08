using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            Console.Write("Whitch value you want to see of contains: ");
            var value = int.Parse(Console.ReadLine()!);
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            if (myArray.Contains(value))
            {
                Console.WriteLine("Conatins");
            }
            else
            {
                Console.WriteLine("Does not contain");
            }
        }
    }
}
