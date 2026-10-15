char letter = char.ToUpper(Convert.ToChar(Console.ReadLine()));

switch (letter)
{
    case 'A':
    case 'E':
    case 'I':
    case 'O':
    case 'U':
        Console.WriteLine("VOWEL");
        break;
    default:
        Console.WriteLine("CONSONANT");
        break;
}


