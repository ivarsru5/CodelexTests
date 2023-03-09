using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            //todo - write a program in C# to display the first 10 natural numbers
            for (var index = 1; index <= 10; index++)
            {
                numbers.Add(index);
            }
            Console.WriteLine("The first 10 natural numbers are: {0}", string.Join(",", numbers.ToArray()));
        }
    }
}
