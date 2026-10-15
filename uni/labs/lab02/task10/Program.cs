int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int x = 2; x <= n; x++)
{
    bool isPrime = true;

    for (int i = 2; i < x; i++)
    {
        if (x % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime) sum += x;
}
Console.WriteLine(sum);