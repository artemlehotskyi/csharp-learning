string input = Console.ReadLine()!;

int dotIndex = input.IndexOf('.');

int first = Convert.ToInt32(input.Substring(dotIndex + 1, 1));
int second = Convert.ToInt32(input.Substring(dotIndex + 2, 1));

int sum = first + second;
Console.WriteLine(sum);
