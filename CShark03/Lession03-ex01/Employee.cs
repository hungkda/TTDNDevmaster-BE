using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession03_ex01
{
    internal class Employee
    {
        private int id;
        private string name;
        private int year;
        private double salaryLevel;
        private double basicSalary;

        public Employee() { }
        public Employee(int id, string name, int year,double basicSalary, double salaryLevel)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.basicSalary = basicSalary;
            this.salaryLevel = salaryLevel;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double SalaryLevel { get { return salaryLevel; } set { salaryLevel = value; } }
        public double BasicSalary { get { return basicSalary; } set { basicSalary = value; } }

        public double GetInCome()
        {
            return salaryLevel * basicSalary;
        }

        public void Display() 
        {          
            Console.WriteLine("Mã nhân viên: " + id);
            Console.WriteLine("Tên nhân viên: " + name);
            Console.WriteLine("lương cơ bản: " + basicSalary);
            Console.WriteLine("Thu nhập: " + GetInCome());
            Console.WriteLine("");
        }
    }
}
