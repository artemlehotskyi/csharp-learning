int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int row = 0; row < n; row++)
{
    for (int column = 0; column < n; column++)
    {
        matrix[row, column] = Convert.ToInt32(Console.ReadLine());
    }
}


for (int column = n - 1; column >= 0; column--)
{
    for (int row = 0; row <= n - 1; row++)
    {
        Console.WriteLine(matrix[row, column]);
    }
}
