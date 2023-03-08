using System;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            int sum = 0;
            for (var index = 0; index < numbers.Length; index ++)
            {
                sum += numbers[index];
            }

            var value = sum / numbers.Length;

            Console.WriteLine("Average value of the array elements is : " + value);
            
        }
    }
}
