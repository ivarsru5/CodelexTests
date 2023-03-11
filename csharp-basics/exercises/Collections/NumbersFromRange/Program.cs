using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            //ToDo: Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
            numbers = numbers.Where(x => x > 30 && x < 100).ToList();
            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}
