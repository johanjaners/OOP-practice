
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

    public void AddStudent(Student s)
    {
        Students.Add(s);
    }
}

class Program
{
    static void Main()
    {
        var C = new Classroom();

        C.AddStudent(new Student("David", 5));
        C.AddStudent(new Student("Ken", 10));
        C.AddStudent(new Student("Sara", 8));

        foreach(var student in C.Students) // looping through each student in Student list of Object C (instance of Classroom)
            Console.WriteLine(student.Name);

    }
}