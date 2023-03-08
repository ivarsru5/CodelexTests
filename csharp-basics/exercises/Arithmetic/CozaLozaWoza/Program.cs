namespace CozaLozaWoza;
class Program
{
    static void Main(string[] args)
    {
        int lowerBound = 1;
        int upperBound = 110;
        int numbersPerLine = 11;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("CozaLoza ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Coza ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Loza ");
            }
            else if (i % 7 == 0)
            {
                Console.Write("Woza ");
            }
            else
            {
                Console.Write("{0} ", i);
            }

            if (i % numbersPerLine == 0)
            {
                Console.WriteLine();
            }
        }
    }
}

