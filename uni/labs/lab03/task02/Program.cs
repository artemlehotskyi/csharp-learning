int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int target = Convert.ToInt32(Console.ReadLine());
int foundIndex = -1;

for (int i = 0; i < n; i++)
{
    if (array[i] == target)
    {
        foundIndex = i;
        break;
    }
}

if (foundIndex != -1)
{
    Console.WriteLine(foundIndex);
}
else
{
    Console.WriteLine("NOT_FOUND");
}

