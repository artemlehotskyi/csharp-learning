int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

var result = FindMaxMin(array);
Console.WriteLine(result.max);
Console.WriteLine(result.min);

static (int max, int min) FindMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
    }

    return (max, min);
}

