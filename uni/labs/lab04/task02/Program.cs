using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

string model = Console.ReadLine()!;
string color = Console.ReadLine()!;
double price = double.Parse(Console.ReadLine()!);

Car car = new Car(model, color, price);
car.ChangePrice(double.Parse(Console.ReadLine()!));
Console.WriteLine(car.GetInfo());
class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public double Price { get; private set; }

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

    public void ChangePrice(double percentage)
    {
        Price = Price + Price * percentage / 100;
    }
}