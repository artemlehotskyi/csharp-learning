System.Globalization.CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

string shape = Console.ReadLine()!;

switch (shape)
{
   case "CIRCLE":
   {
      double result = CircleArea(Convert.ToDouble(Console.ReadLine()));
      Console.WriteLine(result);
      break;
   }
   case "RECTANGLE":
   {
      double result = RectangleArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

      Console.WriteLine(result);
      break;
   }
   case "CUBE":
   {
      double result = CubeVolume(Convert.ToDouble(Console.ReadLine()));
      Console.WriteLine(result);
      break;
   }
}



static double CircleArea(double r)
{
   return Math.PI * r * r;
}
static double RectangleArea(double w, double h)
{
   return w * h;
}
static double CubeVolume(double a)
{
   return a * a * a;
}