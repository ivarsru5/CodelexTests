using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) 
            {
                sum += number;
            }
            Console.WriteLine("Summ is {0}", sum);
            Console.WriteLine("Average summ is: {0}", (double) sum / upperBound);
        }
    }
}
