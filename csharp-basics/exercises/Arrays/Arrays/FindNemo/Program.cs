namespace FindNemo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindNemoFunc("I am Nemo and dont know anything !"));
    }

    static string FindNemoFunc(string input)
    {
        var words = input.Split(' ');
        var result = "";
        for (var index = 0; index < words.Length; index++)
        {
            if (words[index] == "Nemo")
            {
                result = "I found Nemo at " + index;
                break;
            }
            else
            {
                result = "I cant find nemo";
            }
        }
        return result;
    }
}

