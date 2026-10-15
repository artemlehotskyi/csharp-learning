using System.Globalization;

double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double ab = Math.Max(a, b);
double max = Math.Max(ab, c);


if ((a == max && b == max) || (b == max && c == max) || (a == max && c == max))
{
    Console.WriteLine("TIE");
}
else if (a == max)
{
    Console.WriteLine("a");
}
else if (b == max)
{
    Console.WriteLine("b");
}
else
{
    Console.WriteLine("c");
}