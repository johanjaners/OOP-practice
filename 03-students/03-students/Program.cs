
class Student
{
    public string Name { get; set; } // property of student with name

    public int Grade { get; set; } // property

    public Student(string name, int grade, int year) // constructor
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

    }
}