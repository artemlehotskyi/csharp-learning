string text = Console.ReadLine()!.ToUpper();


var result = CountLetters(text);
Console.WriteLine(result.vowels);
Console.WriteLine(result.consonants);

static (int vowels, int consonants) CountLetters(string text)
{
    int vowels = 0;
    int consonants = 0;
    
    foreach (char i in text)
    {
        if (i >= 'A' && i <= 'Z')
        {
            if ("AEIOU".Contains(i))
            {
                vowels++;
            }
            else
            {
                consonants++;
            }
        }
    }
    return (vowels, consonants);
}