int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int summ = 0;

for (int i = 0; i < n; i++)
{
    if (array[i] > 0)
    {
        summ += array[i];
    }
}
Console.WriteLine(summ);
