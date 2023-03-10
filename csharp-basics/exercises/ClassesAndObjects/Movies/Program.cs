namespace Movies;
class Program
{
    static void Main(string[] args)
    {
        List<Move> moves = new List<Move>();
        moves.Add(new Move("Casino Royale", "Eon Productions", "PG13"));
        moves.Add(new Move("Glass", "Buena Vista International", "PG13"));
        moves.Add(new Move("Spider-Man: Into the Spider-Verse", "Columbia Pictures"));
        var collected = GetMoves(moves);
        foreach (var move in collected)
        {
            Console.WriteLine(move.Title);
        }
    }

    static Move[] GetMoves(List<Move> moves)
    {
        var moveArray = moves.Where(movieInstance => movieInstance.Rating == "PG");
        return moveArray.ToArray();
    }
}

