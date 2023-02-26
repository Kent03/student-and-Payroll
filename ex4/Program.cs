using System;
using System.Collections.Generic;

namespace ScientificInstitute
{
    //lehoangkhoi-20mc-20it438
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách cho từng loại nhân viên
            List<Scientist> scientists = new List<Scientist>();
            List<Manager> managers = new List<Manager>();
            List<LaboratoryStaff> laboratoryStaff = new List<LaboratoryStaff>();

            // Thêm một số nhân viên vào danh sách để kiểm tra
            scientists.Add(new Scientist("John Doe", 1980, "PhD", "Senior Researcher", 10, 20, 5));
            scientists.Add(new Scientist("Jane Smith", 1990, "PhD", "Researcher", 5, 15, 3));
            managers.Add(new Manager("Bob Johnson", 1975, "MBA", "Department Manager", 20, 7));
            laboratoryStaff.Add(new LaboratoryStaff("Sarah Lee", 2000, "High School Diploma", 2000));

            // Tính tổng lương trả cho từng loại nhân viên
            double totalScientistSalary = 0;
            foreach (Scientist scientist in scientists)
            {
                totalScientistSalary += scientist.CalculateSalary();
            }

            double totalManagerSalary = 0;
            foreach (Manager manager in managers)
            {
                totalManagerSalary += manager.CalculateSalary();
            }

            double totalLaboratoryStaffSalary = 0;
            foreach (LaboratoryStaff staff in laboratoryStaff)
            {
                totalLaboratoryStaffSalary += staff.Salary;
            }

            // In danh sách nhân viên và tổng lương trả cho từng loại nhân viên
            Console.WriteLine("Cac nha khoa hoc:");
            foreach (Scientist scientist in scientists)
            {
                Console.WriteLine(scientist.ToString());
            }
            Console.WriteLine("Tong luong tra cho cac nha khoa hoc: $" + totalScientistSalary);

            Console.WriteLine("\nManagers:");
            foreach (Manager manager in managers)
            {
                Console.WriteLine(manager.ToString());
            }
            Console.WriteLine("Tong luong tra cho can bo quan ly: $" + totalManagerSalary);

            Console.WriteLine("\nLaboratory staff:");
            foreach (LaboratoryStaff staff in laboratoryStaff)
            {
                Console.WriteLine(staff.ToString());
            }
            Console.WriteLine("Tong luong tra cho nhan vien phong thi nghiem: $" + totalLaboratoryStaffSalary);

            Console.ReadLine();
        }
    }

    class Employee
    {
        public string FullName { get; set; }
        public int YearOfBirth { get; set; }
        public string Degree { get; set; }

        public Employee(string fullName, int yearOfBirth, string degree)
        {
            FullName = fullName;
            YearOfBirth = yearOfBirth;
            Degree = degree;
        }
    }

    //Tạo lớp Scientist kế thừa từ employee
    class Scientist : Employee
    {
        public string Position { get; set; }
        public int NumPublishedArticles { get; set; }
        public int NumWorkingDays { get; set; }
        public int SalaryGrade { get; set; }

        public Scientist(string fullName, int yearOfBirth, string degree, string position,
            int numPublishedArticles, int numWorkingDays, int salaryGrade) : base(fullName, yearOfBirth, degree)
        {
            Position = position;
            NumPublishedArticles = numPublishedArticles;
            NumWorkingDays = numWorkingDays;
            SalaryGrade = salaryGrade;
        }

        //tính lương của nhân viên dựa trên số ngày làm việc và bậc/bậc lương 
        public double CalculateSalary()
        {
            return NumWorkingDays * SalaryGrade;
        }

        //ToString` trả về một biểu diễn chuỗi của đối tượng nhân viên
        public override string ToString()
        {
            return FullName + " - " + YearOfBirth + " - " + Degree + " - " + Position + " - " +
                NumPublishedArticles + " - " + NumWorkingDays + " - $" + CalculateSalary();
        }
    }

    //lớp manager kế thừa từ employee
    class Manager : Employee
    {
        public string Position { get; set; }
        public int NumWorkingDays { get; set; }
        public int SalaryLevel { get; set; }

        public Manager(string fullName, int yearOfBirth, string degree, string position,
            int numWorkingDays, int salaryLevel) : base(fullName, yearOfBirth, degree)
        {
            Position = position;
            NumWorkingDays = numWorkingDays;
            SalaryLevel = salaryLevel;
        }

        //tính lương của nhân viên dựa trên số ngày làm việc và bậc/bậc lương 
        public double CalculateSalary()
        {
            return NumWorkingDays * SalaryLevel;
        }

        //ToString` trả về một biểu diễn chuỗi của đối tượng nhân viên

        public override string ToString()
        {
            return FullName + " - " + YearOfBirth + " - " + Degree + " - " + Position + " - " +
                NumWorkingDays + " - $" + CalculateSalary();
        }
    }

    //Lớp LaboratoryStaff kế thừa Employee
    class LaboratoryStaff : Employee
    {
        public double Salary { get; set; }

        public LaboratoryStaff(string fullName, int yearOfBirth, string degree, double salary) :
            base(fullName, yearOfBirth, degree)
        {
            Salary = salary;
        }

        //ToString` trả về một biểu diễn chuỗi của đối tượng nhân viên

        public override string ToString()
        {
            return FullName + " - " + YearOfBirth + " - " + Degree + " - $" + Salary;
        }
    }
}
