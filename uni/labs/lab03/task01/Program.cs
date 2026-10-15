int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int left = 0;
int right = n - 1;
bool isPalindrome = true;

while (left < right)
{
    if (array[left] != array[right])
    {
        isPalindrome = false;
        break;
    }
    left++;
    right--;
}

if (isPalindrome)
{
    Console.WriteLine("PALINDROME");
}
else
{
    Console.WriteLine("NOT_PALINDROME");
}
