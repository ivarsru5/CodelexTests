namespace LessonTables;
class Program
{
    static void Main(string[] args)
    {
        DrawTable();
    }
    static void DrawTable()
    {
        Dictionary<int, string[]> input = new Dictionary<int, string[]>()
        {
            {1, new string[] {"English III", "Ms. Lapan"}},
            {2, new string[] {"Precalculus", "Mrs. Gideon"}},
            {3, new string[] {"Music Theory", "Mr. Davis"}},
            {4, new string[] {"Biotechnology", "Ms. Palmer"}},
            {5, new string[] {"Principles of Technology I", "Ms. Garcia"}},
            {6, new string[] {"Latin II", "Mrs. Barnett"}},
            {7, new string[] {"AP US History", "Ms. Johannessen"}},
            {8, new string[] {"Business Computer Infomation Systems", "Mr. James"}}
        };

        Console.WriteLine("+------------------------------------------------------------+");
        foreach (KeyValuePair<int, string[]> entry in input)
        {
            Console.WriteLine($"| {entry.Key} | {entry.Value[0],36} | {entry.Value[1],15} |");
        }
        Console.WriteLine("+------------------------------------------------------------+");
    }
}

