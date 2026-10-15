using System.Globalization;

double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("VALID");
}
else 
{
    Console.WriteLine("INVALID");
}
