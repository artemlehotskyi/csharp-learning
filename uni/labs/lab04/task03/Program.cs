int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);


Point point = new Point(X, Y);

point.Move(int.Parse(Console.ReadLine()!),int.Parse(Console.ReadLine()!));
Console.WriteLine(point.X);
Console.WriteLine(point.Y);

class Point
{
    public int X { get; private set; }
    public int Y { get; private set; }


    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Move(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }
}