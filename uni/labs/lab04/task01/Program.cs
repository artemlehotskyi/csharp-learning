using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

string model = Console.ReadLine()!;
string color = Console.ReadLine()!;
double price = double.Parse(Console.ReadLine()!);

Car car = new Car(model, color, price);
Console.WriteLine(car.GetInfo());

class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }

    public const string BrandName = "AUDI";

    public Car(string model, string color, double price)
    {
        Model = model;
        Color = color;
        Price = price;
    }

    public string GetInfo()
    {
        return $"{BrandName} {Model} {Color} {Price}";
    }
}
