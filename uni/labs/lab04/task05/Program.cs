string mode = Console.ReadLine()!;

Student student;

if (mode == "PARAMS")
{
    string name = Console.ReadLine()!;
    int grade = int.Parse(Console.ReadLine()!);
    student = new Student(name, grade);
}
else
{
    student = new Student();
}

Console.WriteLine(student.GetInfo());

class Student
{
    public string Name { get; private set; }
    public int Grade { get; private set; }
    
    
    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }

    public Student()
    {
        Name = "UNKNOWN";
        Grade = 0;
    }

    public string GetInfo()
    {
        return $"{Name} {Grade}";
    }
}
