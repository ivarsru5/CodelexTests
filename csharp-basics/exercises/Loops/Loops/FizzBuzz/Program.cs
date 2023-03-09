namespace FizzBuzz;
class FizzBuzz
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine()!);

        for (int index = 1; index <= number; index++)
        {
            if (index % 3 == 0 && index % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (index % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (index % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write(index + " ");
            }

            if (index % 20 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}


