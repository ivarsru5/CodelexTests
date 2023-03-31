namespace BMI;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your height: ");
        var height = int.Parse(Console.ReadLine()!);
        Console.Write("Enter your wight: ");
        var weight = int.Parse(Console.ReadLine()!);

        CauculateBMI(height, weight);
    }

    static void CauculateBMI(int height, int weight)
    {
        var bmi = weight * 703 / Math.Pow(height, 2);
        if (bmi >= 18.5 && bmi <= 25)
        {
            Console.WriteLine("BMI is optimal");
        }else if (bmi < 18.5)
        {
            Console.WriteLine("BMI is underwaight");
        }else if (bmi > 25)
        {
            Console.WriteLine("BMI is overwaight");
        }
    }
}

