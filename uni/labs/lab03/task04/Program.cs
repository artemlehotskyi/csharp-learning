int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int row = 0; row < n; row++)
{
    for (int column = 0; column < n; column++)
    {
        matrix[row, column] = Convert.ToInt32(Console.ReadLine());
    }
}
int summ = 0;


for (int i = 0; i < n; i++)
{
    summ += matrix[i, i];
}
Console.WriteLine(summ);