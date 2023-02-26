using System;
using System.Collections.Generic;

//LeHoangKhoi-20mc-20it438
public class Student
{
    // Tạo ra các thuộc tính sid,name,faculty,gpa
    private string sid;
    private string name;
    private string faculty;
    private double gpa;

    public Student(string sid, string name, string faculty, double gpa)
    {
        this.sid = sid;
        this.name = name;
        this.faculty = faculty;
        this.gpa = gpa;
    }

    //Tạo get set

    public string SID
    {
        get { return sid; }
        set { sid = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Faculty
    {
        get { return faculty; }
        set { faculty = value; }
    }

    public double GPA
    {
        get { return gpa; }
        set { gpa = value; }
    }

    //hiển thị thông tin của một đối tượng sinh viên
    public void Display()
    {
        Console.WriteLine("SID: " + sid);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Faculty: " + faculty);
        Console.WriteLine("GPA: " + gpa);
        Console.WriteLine();
    }
}
//nhập thông tin từ người dùng và tạo danh sách sinh viên
public class Tester
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter information for student " + (i + 1) + ":");
            Console.Write("SID: ");
            string sid = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Faculty: ");
            string faculty = Console.ReadLine();
            Console.Write("GPA: ");
            double gpa = Convert.ToDouble(Console.ReadLine());

            Student student = new Student(sid, name, faculty, gpa);
            students.Add(student);

            Console.WriteLine();
        }

        Console.WriteLine("Student List:");
        foreach (Student student in students)
        {
            student.Display();
        }

        Console.ReadLine();
    }
}
