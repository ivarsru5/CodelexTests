using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        //TODO: Write a C# program to find the index of an array element.
        private static void Main(string[] args)
        {
            Console.Write("Enter number to find its index: ");
            var number = int.Parse(Console.ReadLine()!);

            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};

            var elementIndex = 0;

            for (var index = 0; index<myArray.Length; index++)
            {
                if (number == myArray[index])
                {
                    elementIndex = index;
                }
            }

            Console.WriteLine("Index position of {0} is: {1}", number, elementIndex);
            
            //Expected output:
            //Index position of 36 is: 4
            //Index position of 29 is: 8
            
        }
    }
}
