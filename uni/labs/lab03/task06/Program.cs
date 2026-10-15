System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
string op = Console.ReadLine()!;


static string Calculate(double a, double b, string op)
{
    switch (op)
    {
        case "ADD":
            return (a + b).ToString();
        case "SUB":
            return (a - b).ToString();
        case "MUL":
            return (a * b).ToString();
        case "DIV":
            if (b == 0)
            {
                return "DIV_BY_ZERO";
            }

            return (a / b).ToString();
    }
    return "";
}
Console.WriteLine(Calculate(a, b, op));