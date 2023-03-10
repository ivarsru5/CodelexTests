namespace Points;
class Program
{
    static void Main(string[] args)
    {
        var p1 = new Points(-1, -2);
        var p2 = new Points(1, 2);
        Points.SwitchPoints(ref p1, ref p2);

        Console.WriteLine("x = {0}, y = {1}", p1.x, p1.y);
    }
}