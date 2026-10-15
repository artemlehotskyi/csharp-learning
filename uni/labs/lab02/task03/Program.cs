using System.Globalization;

double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double result =  x switch
{
    < 10000 => 0,
    < 50000 => x * 0.10,
    < 100000 => x * 0.20,
    _ => x * 0.30
};
Console.WriteLine(result);