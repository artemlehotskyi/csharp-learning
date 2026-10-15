int limit = Convert.ToInt32(Console.ReadLine());

int previous = 0;
int current = 1;

int sum = 0;
int count = 0;

while (current < limit)
{
    sum += current;
    count++;

    int next = previous + current;
    previous = current;
    current = next;
}

Console.WriteLine(sum);
Console.WriteLine(count);