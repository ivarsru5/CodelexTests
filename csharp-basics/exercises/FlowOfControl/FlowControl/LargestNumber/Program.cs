using System;
using System.Linq;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Input the 2nd number: ");
            var input2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Input the 3rd number: ");
            var input3 = int.Parse(Console.ReadLine()!);

            var inputs = new int[]
            {
                input1, input2, input3
            };
            
            Console.WriteLine("Largest number is: {0}", inputs.Max());
        }
    }
}
