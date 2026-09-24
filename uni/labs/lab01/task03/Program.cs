int h = Convert.ToInt32(Console.ReadLine());

if (h < 0 || h > 23)
{
    Console.WriteLine("Некоректна година!");
}
else if (h < 6)
{
    Console.WriteLine("Доброї ночі!");
}
else if (h < 12)
{
    Console.WriteLine("Доброго ранку!");
}
else if (h < 18)
{
    Console.WriteLine("Добрий день!");
}
else
{
    Console.WriteLine("Добрий вечір!");
}


/* Альтернатива через Switch
 string message = h switch
   {
       < 0 or > 23 => "Некоректна година!",
       < 6 => "Доброї ночі!",
       < 12 => "Доброго ранку!",
       < 18 => "Добрий день!",
       _ => "Добрий вечір!" // Символ '_' діє як default
   };
 */
