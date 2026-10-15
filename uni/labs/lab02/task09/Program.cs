int n = Convert.ToInt32(Console.ReadLine());


long factorial = 1;

for (int i = 1; i <= n; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);
