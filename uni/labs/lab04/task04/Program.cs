string name = Console.ReadLine()!;
int birthYear = int.Parse(Console.ReadLine()!);
int currentYear = int.Parse(Console.ReadLine()!);

Person person = new Person(name, birthYear);
int age = person.Age(currentYear);

if (age < 16)
{
    person.ChangeName("VERY_YOUNG");
}
Console.WriteLine(person.Name);
Console.WriteLine(age);


class Person
{
    public string Name  { get; private set; }
    public int BirthYear { get;  private set; }

    public Person(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }
    
    public void ChangeName(string name)
    {
        Name = name;
    }

    public int Age(int currentYear)
    {
        return currentYear - BirthYear;
    }
}
