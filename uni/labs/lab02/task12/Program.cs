int first_num = Convert.ToInt32(Console.ReadLine());
int second_num = Convert.ToInt32(Console.ReadLine());

int max_divider = 0;

for (int i = 1; i <= Math.Min(first_num, second_num); i++)
{
    if (first_num % i == 0 && second_num % i == 0)
    {
        max_divider = i;
    }
}
Console.WriteLine(max_divider);