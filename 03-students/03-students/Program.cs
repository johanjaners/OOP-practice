
class Student
{
    public string Name { get; set; } // property of student with name
    public int Grade { get; set; } // property
    public Student(string name, int grade) // constructor
    {
        this.Name = name;
        this.Grade = grade;
    }
}
class Classroom
{
    public List<Student> Students { get; } = new();
    public void AddStudent(Student s) => Students.Add(s);
}

class School
{
    public string Name { get; set; }
    public List<Classroom> Classrooms { get; } = new();
    public School(string name) => this.Name = name;
    public void AddClassroom(Classroom c) => Classrooms.Add(c);
}

class Program
{
    static void Main()
    {
        var C = new Classroom();
        C.AddStudent(new Student("David", 5));
        C.AddStudent(new Student("Ken", 10));
        C.AddStudent(new Student("Sara", 8));

        Console.WriteLine("Students in Classroom 1: ");
        foreach (var student in C.Students) // looping through each student in Student list of Object C (instance of Classroom)
            Console.WriteLine(student.Name);

        Console.WriteLine("Total students in Classroom 1: " + C.Students.Count);

        var S = new School("SALT groundschool");

        S.AddClassroom(C);

        var C2 = new Classroom();
        C2.AddStudent(new Student("X", 6));

        S.AddClassroom(C2);
        Console.WriteLine("Total students in Classroom 2: " + C2.Students.Count);

        Console.WriteLine("School name: " + S.Name);
        Console.WriteLine("Classrooms in School: " + S.Classrooms.Count);

        int totalstudents = 0;
        foreach (var c in S.Classrooms)
            totalstudents += c.Students.Count;

        Console.WriteLine("No of Students in School: " + totalstudents);
    }
}