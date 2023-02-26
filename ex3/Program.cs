using System;
using System.Collections.Generic;

//lehoangkhoi-20mc-20it438
class People
{
    //tạo lớp people với name và department
    public string Name { get; set; }
    public string Department { get; set; }
}

class Student : People
{
    //lớp Student kế thừa từ lớp People 
    public int SID { get; set; }
    public double AverageGrade { get; set; }

    //phương thức Show() để hiển thị thông tin của từng sinh viên.
    public void Show()
    {
        Console.WriteLine("Student ID: " + SID);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Average Grade: " + AverageGrade);
    }
}

class Tester
{
    //hàm main xuất danh sách
    static void Main(string[] args)
    {
        //sử dụng lớp collection List để chứa danh sách sinh viên
        List<Student> studentList = new List<Student>();

        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        //sử dụng vòng lặp for để nhập thông tin cho từng sinh viên 
        for (int i = 0; i < n; i++)
        {
            Student student = new Student();

            Console.Write("Enter student ID: ");
            student.SID = int.Parse(Console.ReadLine());

            Console.Write("Enter student name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter student department: ");
            student.Department = Console.ReadLine();

            Console.Write("Enter student average grade: ");
            student.AverageGrade = double.Parse(Console.ReadLine());

            studentList.Add(student);
        }

        Console.WriteLine("\nStudent List:");
        //foreach để duyệt qua danh sách sinh viên 
        foreach (Student student in studentList)
        {
            student.Show();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
