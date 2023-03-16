namespace ArrayElementCounting;
class Program
{
    static void Main(string[] args)
    {
        int[] numArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
        var result = CountElements(numArray);
        Console.WriteLine(string.Join(",", result));
    }

    static List<int> CountElements(int[] intArray)
    {
        List<int> completed = new List<int>();
        int positive = 0;
        int negative = 0;
        foreach (var element in intArray)
        {
            if (element < 0)
            {
                negative += element;
            }
            else
            {
                positive += 1;
            }
        }

        completed.Add(positive);
        completed.Add(negative);
        return completed;
    }
}

