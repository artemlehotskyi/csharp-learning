int year = Convert.ToInt32(Console.ReadLine());

if (year < 1)
{
    Console.WriteLine("Invalid year");
}
else if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine("LEAP");
}
else
{
    Console.WriteLine("NOT_LEAP");
}
