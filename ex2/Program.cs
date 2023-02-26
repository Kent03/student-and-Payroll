using System;
using System.Collections.Generic;

public class Student
{
    //lehoangkhoi-20mc-20it438
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

    //mà sử dụng các
    //phương thức getter và setter
    //để truy cập và thay đổi các giá trị của dữ liệu thành viên
    public string GetSID()
    {
        return sid;
    }

    public void SetSID(string sid)
    {
        this.sid = sid;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetFaculty()
    {
        return faculty;
    }

    public void SetFaculty(string faculty)
    {
        this.faculty = faculty;
    }

    public double GetGPA()
    {
        return gpa;
    }

    public void SetGPA(double gpa)
    {
        this.gpa = gpa;
    }

    //hiển thị thông tin của một đối tượng sinh viên
    public void Show()
    {
        Console.WriteLine("SID: " + sid);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Faculty: " + faculty);
        Console.WriteLine("GPA: " + gpa);
        Console.WriteLine();
    }
}

//viết các hàm Nhap1SV() để nhập thông tin cho một đối tượng sinh viên, NhapDS() ,XuatDS() 
public class Tester
{
    static void Main(string[] args)
    {
        List<Student> students = NhapDS();

        Console.WriteLine("Student List:");
        XuatDS(students);

        Console.ReadLine();
    }

   // Nhap1SV() để nhập thông tin cho một đối tượng sinh viên
    static Student Nhap1SV()
    {
        Console.WriteLine("Enter information for a student:");
        Console.Write("SID: ");
        string sid = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Faculty: ");
        string faculty = Console.ReadLine();
        Console.Write("GPA: ");
        double gpa = Convert.ToDouble(Console.ReadLine());

        Student student = new Student(sid, name, faculty, gpa);

        return student;
    }

    //NhapDS() để nhập danh sách sinh viên và trả về danh sách
    static List<Student> NhapDS()
    {
        Console.Write("Enter the number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            Student student = Nhap1SV();
            students.Add(student);
        }

        return students;
    }

    //XuatDS() để hiển thị danh sách sinh viên 
    static void XuatDS(List<Student> students)
    {
        foreach (Student student in students)
        {
            student.Show();
        }
    }
}
