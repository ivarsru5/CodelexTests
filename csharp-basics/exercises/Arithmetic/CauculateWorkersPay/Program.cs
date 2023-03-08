namespace CauculateWorkersPay;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter worked hours: ");
        var hours = int.Parse(Console.ReadLine()!);
        Console.Write("Enter rate: ");
        var rate = int.Parse(Console.ReadLine()!);

        CauculatePay(rate, hours);
    }

    static void CauculatePay(int rate, int workedHours)
    {
        if (rate >= 8 && workedHours <= 60)
        {
            if (workedHours > 40)
            {
                var overTime = workedHours - 40;
                var overTimeRate = rate * 1.5;
                var overtimeSalary = overTime * overTimeRate;
                var baseSalary = 40 * rate;
                var sum = overtimeSalary + baseSalary;
                Console.WriteLine("Total salary for this worker is {0}", sum);
            }
            else
            {
                Console.WriteLine("Total salary for this worker is {0}", workedHours * rate);
            }
        }
        else
        {
            Console.WriteLine("Error cauculating salary. Please check input data!");
        }
    }
}