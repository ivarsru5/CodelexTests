using System.Linq;

namespace RandimIntarrays;
class Program
{
    static void Main(string[] args)
    {
        var array1 = CreateArray();
        var array2 = (int[])array1.Clone();
        array1[array1.Length - 1] = -7;

        Console.WriteLine(string.Join(",", array1));
        Console.WriteLine(string.Join(",", array2));
    }

    static int[] CreateArray()
    {
        int Min = 0;
        int Max = 100;
        Random randNum = new Random();
        int[] numArray = Enumerable
            .Repeat(0, 10)
            .Select(i => randNum.Next(Min, Max))
            .ToArray();
        return numArray;
    }
}

