using System.Globalization;

double a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
double b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

double area = a * b;

Console.WriteLine($"The area of {a} and {b} is {area}");
