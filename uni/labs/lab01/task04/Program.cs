int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());
int third = Convert.ToInt32(Console.ReadLine());

int max = first;
int min = first;

// max

if (max < second)
{
    max = second;
    
}
if (max < third)
{
    max = third;
}
//min

if (min > second)
{
    min = second;
}
if (min > third)
{
    min = third;
}

Console.WriteLine(max);
Console.WriteLine(min);