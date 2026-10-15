int n = Convert.ToInt32(Console.ReadLine());

if (IsPrime(n))
{
    Console.WriteLine("PRIME");
}
else
{
    Console.WriteLine("NOT_PRIME");
}

static bool IsPrime(int n)
{
    if (n <= 1) return false;

    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}         