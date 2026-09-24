string dayText = Console.ReadLine();
string monthText = Console.ReadLine();


int day = Convert.ToInt32(dayText);
int month = Convert.ToInt32(monthText);

if (day >= 1 && day <= 31 && month >= 1 && month <= 12)
{
    Console.WriteLine("VALID");
}

else Console.WriteLine("INVALID");


